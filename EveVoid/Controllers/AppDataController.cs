using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        //private static string callbackURL = "https://localhost:44324/fetch-data";

        public static string BASE_AUTH_URL = "https://login.eveonline.com/oauth/authorize?response_type=code&redirect_uri=";
        public AppDataController(IConfiguration configuration)
        {
            _configuration = configuration;
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
    }
}
