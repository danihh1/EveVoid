using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EveVoid.Services.EveObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EveVoid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ICorporationService _corporationService;
        //private static string callbackURL = "https://localhost:44324/fetch-data";

        public static string BASE_AUTH_URL = "https://login.eveonline.com/oauth/authorize?response_type=code&redirect_uri=";
        public AppDataController(IConfiguration configuration, 
            ICorporationService corporationService)
        {
            _configuration = configuration;
            _corporationService = corporationService;
        }
        [HttpGet("GetSSOLoginLink")]
        public string GetSSOLoginLink()
        {
            return BASE_AUTH_URL + _configuration.GetValue<string>("BaseUrl") + "/callback&client_id=" + _configuration.GetValue<string>("ClientId");
        }
        [HttpGet("GetEsiLoginLink")]
        public string GetEsiLoginLink()
        {
            return BASE_AUTH_URL + _configuration.GetValue<string>("BaseUrl") + "/callback-esi&client_id=" + _configuration.GetValue<string>("ClientIdLocation")
                + "&scope=esi-location.read_location.v1 esi-location.read_ship_type.v1";
        }
        [HttpGet("GetBaseUrl")]
        public string GetBaseUrl()
        {
            return _configuration.GetValue<string>("BaseUrl");
        }
        [HttpGet("GetMainCorpId")]
        public int GetMainCorpId()
        {
            return _configuration.GetValue<int>("MainCorpId");
        }
        [HttpGet("GetMainCorpName")]
        public string GetMainCorpName()
        {
            var corpId = _configuration.GetValue<int>("MainCorpId");
            var corp = _corporationService.GetCorporationById(corpId);
            return corp.Name;
        }
        [HttpGet("GetMainAllianceId")]
        public int GetMainAllianceId()
        {
            var corpId = _configuration.GetValue<int>("MainCorpId");
            var corp = _corporationService.GetCorporationById(corpId);
            return corp.AllianceId.GetValueOrDefault();
        }
        [HttpGet("GetMainAllianceName")]
        public string GetMainAllianceName()
        {
            var corpId = _configuration.GetValue<int>("MainCorpId");
            var corp = _corporationService.GetCorporationById(corpId);
            return corp.Alliance?.Name;
        }
    }
}
