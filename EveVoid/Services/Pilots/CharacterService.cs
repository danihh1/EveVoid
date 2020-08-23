using EveVoid.Data;
using EveVoid.Dto;
using EveVoid.Extensions;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Pilots;
using EveVoid.Models.Responses;
using EveVoid.Services.EveObjects;
using EveVoid.Services.Navigation;
using EveVoid.Services.Navigation.MapObjects;
using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Pilots
{
    public class CharacterService : ICharacterService
    {
        public EveVoidContext _context { get; set; }
        public ICorporationService _corporationService { get; set; }
        public ILocationApi _locationApi { get; set; }
        public ICharacterApi _characterApi { get; set; }
        public ITokenService _tokenService { get; set; }
        public IShipService _shipService { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }
        public ISignatureService _signatureService { get; set; }
        public IStargateService _stargateService { get; set; }

        public CharacterService(EveVoidContext context,
            ICorporationService corporationService,
            ILocationApi locationApi,
            ICharacterApi characterApi,
            ITokenService tokenService,
            ISolarSystemService solarSystemService,
            IShipService shipService,
            ISignatureService signatureService, 
            IStargateService stargateService)
        {
            _context = context;
            _corporationService = corporationService;
            _locationApi = locationApi;
            _characterApi = characterApi;
            _tokenService = tokenService;
            _solarSystemService = solarSystemService;
            _shipService = shipService;
            _signatureService = signatureService;
            _stargateService = stargateService;
        }

        public MainCharacter CreateOrUpdateMain(MainLoginDto dto)
        {
            var character = _context.MainCharacters.FirstOrDefault(x => x.Id == dto.CharacterId);
            if (character == null || character.ShouldUpdate())
            {
                var esiResult = _characterApi.GetCharactersCharacterId(dto.CharacterId, null, null);
                if (esiResult.CorporationId.HasValue)
                {
                    _corporationService.GetCorporationById(esiResult.CorporationId.Value);
                }
                if (character == null)
                {
                    character = new MainCharacter
                    {
                        Id = dto.CharacterId,
                        Name = dto.CharacterName,
                        AccessToken = dto.AccessToken,
                        RefreshToken = null,
                        CorporationId = esiResult.CorporationId
                    };
                    _context.MainCharacters.Add(character);
                }
                else
                {
                    character.CorporationId = esiResult.CorporationId;
                    character.AccessToken = dto.AccessToken;
                }
                _context.SaveChanges();
            }
            return character;
        }

        public MainCharacter GetMainCharacterByToken(string token)
        {
            var main = _context.MainCharacters.FirstOrDefault(x => x.AccessToken == token);
            foreach (var esi in main.EsiCharacters)
            {
                if (esi.AccessToken == null || esi.TokenExpiresIn <= DateTime.Now)
                {
                    var newToken = _tokenService.GetTokenFromRefreshToken(esi.RefreshToken, version: "Location").Result;
                    esi.AccessToken = newToken.access_token;
                    esi.TokenExpiresIn = DateTime.Now.AddSeconds(newToken.expires_in);
                }
            }
            _context.SaveChanges();
            return main;
        }

        public EsiCharacter AddOrUpdateEsiCharacterToMainToken(string token, OAuthToken authToken, OAuthVerify authVerify)
        {
            var main = GetMainCharacterByToken(token);
            if (main == null)
            {
                return null;
            }
            var esiChar = _context.EsiCharacters.FirstOrDefault(x => x.Id == authVerify.CharacterID);
            if (esiChar == null || esiChar.ShouldUpdate() || esiChar.TokenExpiresIn <= DateTime.Now)
            {
                var esiResult = _characterApi.GetCharactersCharacterId(authVerify.CharacterID, null, null);
                if (esiResult.CorporationId.HasValue)
                {
                    _corporationService.GetCorporationById(esiResult.CorporationId.Value);
                }
                if (esiChar == null)
                {
                    esiChar = new EsiCharacter
                    {
                        Id = authVerify.CharacterID,
                        Name = authVerify.CharacterName,
                        AccessToken = authToken.access_token,
                        RefreshToken = authToken.refresh_token,
                        CorporationId = esiResult.CorporationId,
                        TokenExpiresIn = DateTime.Now.AddSeconds(authToken.expires_in),
                    };
                    main.EsiCharacters.Add(esiChar);
                }
                else
                {
                    esiChar.MainCharacterId = main.Id;
                    esiChar.RefreshToken = authToken.refresh_token;
                    esiChar.CorporationId = esiResult.CorporationId;
                    esiChar.TokenExpiresIn = DateTime.Now.AddSeconds(authToken.expires_in);
                    esiChar.CorporationId = esiResult.CorporationId;
                }
                _context.SaveChanges();
            }
            return esiChar;
        }

        public EsiCharacter GetEsiCharacterWithActiveToken(string mainToken, string esiToken)
        {
            var esi = _context.EsiCharacters.FirstOrDefault(x=> x.AccessToken == esiToken && x.MainCharacter.AccessToken == mainToken);
            if (esi == null)
            {
                return null;
            }
            if (esi.AccessToken == null || esi.TokenExpiresIn <= DateTime.Now)
            {
                var newToken = _tokenService.GetTokenFromRefreshToken(esi.RefreshToken, version: "Location").Result;
                esi.AccessToken = newToken.access_token;
                esi.TokenExpiresIn = DateTime.Now.AddSeconds(newToken.expires_in);
            }
            _context.SaveChanges();
            return esi;
        }

        public EsiCharacter UpdateEsiCharacter(string mainToken, EsiCharacterDto dto)
        {
            var esi = _context.EsiCharacters.FirstOrDefault(x => x.AccessToken == dto.EsiToken && x.MainCharacter.AccessToken == mainToken);
            if (esi == null)
            {
                return null;
            }
            if (esi.PassedLessThan(seconds: 11))
            {
                if (esi.CurrentSystemId != dto.CurrentSystemId)
                {
                    var destoSystem = _solarSystemService.GetSystemById(dto.CurrentSystemId.GetValueOrDefault());
                    var connection = _stargateService.GetStargateByOriginAndDestoId(esi.CurrentSystemId.GetValueOrDefault(), dto.CurrentSystemId.GetValueOrDefault());
                    if (connection == null)
                    {
                        var wormhole = _signatureService.GetOrAddWormholeByOriginAndDestoId(esi.CurrentSystemId.GetValueOrDefault(), dto.CurrentSystemId.GetValueOrDefault());
                        wormhole.Jumps.Add(new Jump
                        {
                            EsiCharacterId = esi.Id,
                            JumpDate = DateTime.Now,
                            ShipId = dto.CurrentShipTypeId.GetValueOrDefault(),
                        });
                    }
                    else
                    {
                        connection.StargateJumps.Add(new StargateJump
                        {
                            EsiCharacterId = esi.Id,
                            JumpDate = DateTime.Now,
                            ShipId = dto.CurrentShipTypeId.GetValueOrDefault(),
                            StargateId = connection.Id
                        });
                    }
                }
            }
            if (dto.CurrentShipTypeId.HasValue) 
            {
                _shipService.GetShipById(dto.CurrentShipTypeId.Value);
                esi.CurrentShipTypeId = dto.CurrentShipTypeId;
            }
            if (dto.CurrentSystemId.HasValue)
            {
                _context.Update(esi);
                _solarSystemService.GetSystemById(dto.CurrentSystemId.Value);
                esi.CurrentSystemId = dto.CurrentSystemId;
            }
            esi.CurrentShipName = dto.CurrentShipName;
            _context.SaveChanges();
            return esi;
        }
    }
}
