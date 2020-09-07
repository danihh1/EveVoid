using EveVoid.Data;
using EveVoid.Dto;
using EveVoid.Extensions;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.MapObjects;
using EveVoid.Models.Navigation.Masks;
using EveVoid.Models.Pilots;
using EveVoid.Models.Responses;
using EveVoid.Services.EveObjects;
using EveVoid.Services.Navigation;
using EveVoid.Services.Navigation.MapObjects;
using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
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
            var esiResult = _characterApi.GetCharactersCharacterId(dto.CharacterId, null, null);
            if (character == null)
            {
                if (esiResult.CorporationId.HasValue)
                {
                    _corporationService.GetCorporationById(esiResult.CorporationId.Value);
                }
                character = new MainCharacter
                {
                    Id = dto.CharacterId,
                    Name = dto.CharacterName,
                    AccessToken = dto.AccessToken,
                    RefreshToken = null,
                    CorporationId = esiResult.CorporationId,
                    MaskType = esiResult.AllianceId.HasValue ? MaskType.Alliance : MaskType.Corp
                };
                _context.MainCharacters.Add(character);
            }
            else
            {
                character.CorporationId = esiResult.CorporationId;
                character.AccessToken = dto.AccessToken;
            }
            _context.SaveChanges();
            return character;
        }

        public MainCharacter GetMainCharacterByToken(string token)
        {
            var main = _context.MainCharacters.FirstOrDefault(x => x.AccessToken == token);
            if (main != null)
            {
                foreach (var esi in main.EsiCharacters)
                {
                    if (esi.AccessToken == null || esi.TokenExpiresIn <= DateTime.UtcNow)
                    {
                        var newToken = _tokenService.GetTokenFromRefreshToken(esi.RefreshToken, version: "Location").Result;
                        esi.AccessToken = newToken.access_token;
                        esi.TokenExpiresIn = DateTime.UtcNow.AddSeconds(newToken.expires_in);
                    }
                }
                _context.SaveChanges();
            }
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
            if (esiChar == null || esiChar.PassedMoreThan() || esiChar.TokenExpiresIn <= DateTime.UtcNow)
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
                        TokenExpiresIn = DateTime.UtcNow.AddSeconds(authToken.expires_in),
                    };
                    main.EsiCharacters.Add(esiChar);
                }
                else
                {
                    esiChar.MainCharacterId = main.Id;
                    esiChar.RefreshToken = authToken.refresh_token;
                    esiChar.CorporationId = esiResult.CorporationId;
                    esiChar.TokenExpiresIn = DateTime.UtcNow.AddSeconds(authToken.expires_in);
                    esiChar.CorporationId = esiResult.CorporationId;
                }
                _context.SaveChanges();
            }
            return esiChar;
        }

        public EsiCharacter GetEsiCharacterWithActiveToken(string mainToken, int esiCharId)
        {
            var esi = _context.EsiCharacters.FirstOrDefault(x=> x.Id == esiCharId && x.MainCharacter.AccessToken == mainToken);
            if (esi == null)
            {
                return null;
            }
            if (esi.AccessToken == null || esi.TokenExpiresIn <= DateTime.UtcNow)
            {
                var newToken = _tokenService.GetTokenFromRefreshToken(esi.RefreshToken, version: "Location").Result;
                esi.AccessToken = newToken.access_token;
                esi.TokenExpiresIn = DateTime.UtcNow.AddSeconds(newToken.expires_in);
            }
            _context.SaveChanges();
            return esi;
        }

        public EsiCharacter UpdateEsiCharacter(string mainToken, EsiCharacterDto dto, int sigId)
        {
            var esi = _context.EsiCharacters.FirstOrDefault(x => x.Id == dto.Id && x.MainCharacter.AccessToken == mainToken);
            if (esi == null)
            {
                return null;
            }
            if (esi.CurrentSystemId != null && esi.PassedLessThan(seconds: 11) && sigId >= 0) // sigId = -1 means angular client didn't notice a change in location
            {
                if (esi.CurrentSystemId != dto.CurrentSystemId)
                {
                    var maskId = esi.MainCharacter.MaskType == MaskType.Alliance ? esi.MainCharacter.Corporation.Alliance.MaskId : esi.MainCharacter.Corporation.MaskId;
                    var destoSystem = _solarSystemService.GetSystemById(dto.CurrentSystemId.GetValueOrDefault());
                    var connection = _stargateService.GetStargateByOriginAndDestoId(esi.CurrentSystemId.GetValueOrDefault(), dto.CurrentSystemId.GetValueOrDefault());
                    if (connection == null)
                    {
                        var wormhole = _signatureService.GetBySignatureId(sigId);
                        if (wormhole == null) // sigId = 0 means it's an unmarked wormhole
                        {
                            wormhole = new Signature
                            {
                                SystemId = esi.CurrentSystemId.Value,
                                SignatureId = "???",
                                ExpiryDate = DateTime.UtcNow.AddDays(1),
                                Name = "",
                                SignatureType = SignatureType.Wormhole,
                                MaskId = maskId,
                                WormholeTypeId = _signatureService.GetByTypeName("????").Id
                            };
                            _signatureService.Insert(wormhole, commit: true);
                        }
                        wormhole.Jumps.Add(new Jump
                        {
                            EsiCharacterId = esi.Id,
                            ShipId = dto.CurrentShipTypeId.GetValueOrDefault()
                        });
                        var destoWormhole = wormhole.Destination;
                        if (destoWormhole == null)
                        {
                            destoWormhole = new Signature
                            {
                                SystemId = dto.CurrentSystemId.Value,
                                SignatureId = "???",
                                ExpiryDate = wormhole.ExpiryDate,
                                Name = "",
                                SignatureType = SignatureType.Wormhole,
                                MaskId = maskId,
                                WormholeTypeId = _signatureService.GetByTypeName("K162").Id
                            };
                            _signatureService.Insert(destoWormhole, commit: true);
                            destoWormhole.DestinationId = wormhole.Id;
                            wormhole.DestinationId = destoWormhole.Id;
                            _signatureService.Update(wormhole, commit: true);
                        }
                        //var wormhole = _signatureService.GetOrAddWormholeByOriginAndDestoId(esi.CurrentSystemId.GetValueOrDefault(), dto.CurrentSystemId.GetValueOrDefault(), maskId, sigId);
                        //wormhole.Wormhole.Jumps.Add(new Jump
                        //{
                        //    EsiCharacterId = esi.Id,
                        //    ShipId = dto.CurrentShipTypeId.GetValueOrDefault()
                        //});
                    }
                    else
                    {
                        connection.StargateJumps.Add(new StargateJump
                        {
                            EsiCharacterId = esi.Id,
                            ShipId = dto.CurrentShipTypeId.GetValueOrDefault(),
                            StargateId = connection.Id,
                            MaskId = maskId
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

        public void UpdateMainCharacter(MainCharacter main)
        {
            _context.Update(main);
            _context.SaveChanges();
        }
    }
}
