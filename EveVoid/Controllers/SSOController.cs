using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EveVoid.Dto;
using EveVoid.Models.Pilots;
using EveVoid.Models.Responses;
using EveVoid.Services;
using EveVoid.Services.Pilots;
using IO.Swagger.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public partial class SSOController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        private readonly ITokenService _tokenService;

        public SSOController(ICharacterService characterService, 
            ITokenService tokenService)
        {
            _characterService = characterService;
            _tokenService = tokenService;
        }

        [HttpGet("ExchangeCodeForToken")]
        public async Task<MainLoginDto> ExchangeCodeForToken(string code)
        {
            var dto = new MainLoginDto();

            var oAuthToken = await _tokenService.GetOAuthToken(code);
            dto.AccessToken = oAuthToken.access_token;

            var oAuthVerify = await _tokenService.GetOAuthVerify(dto.AccessToken);
            dto.CharacterId = oAuthVerify.CharacterID;
            dto.CharacterName = oAuthVerify.CharacterName;

            _characterService.CreateOrUpdateMain(dto);
            return dto;
        }

        [HttpPost("ConfirmAuthCharId")]
        public bool ConfirmAuthCharId(MainLoginDto dto)
        {
            var character = _characterService.GetMainCharacterByToken(dto.AccessToken);
            return character != null && character.AccessToken == dto.AccessToken;
        }

        [HttpPost("ExchangeCodeForTokenEsi")]
        public async Task<bool> ExchangeCodeForTokenEsi([FromBody] EsiLoginDto dto)
        {
            var oAuthToken = await _tokenService.GetOAuthToken(dto.AccessCode,"Location");
            var oAuthVerify = await _tokenService.GetOAuthVerify(oAuthToken.access_token);
            _characterService.AddOrUpdateEsiCharacterToMainToken(dto.MainCharacterToken, oAuthToken, oAuthVerify);
            return true;
        }
    }
}
