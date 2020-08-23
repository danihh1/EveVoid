using EveVoid.Models.Responses;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EveVoid.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public static string OAUTH_TOKEN_URL = "https://login.eveonline.com";
        private string _authString(string version="")
        {
            
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("ClientId" + version) + ":" + _configuration.GetValue<string>("SecretKey" + version)));
            
        }
        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetAuthString(string version = "")
        {
            return _authString(version);
        }

        public async Task<OAuthToken> GetOAuthToken(string code, string version = "")
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri(OAUTH_TOKEN_URL) };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authString(version));

            var response = await client.PostAsync("/oauth/token", new StringContent("grant_type=authorization_code&code=" + code, Encoding.UTF8, "application/x-www-form-urlencoded"));
            return JsonSerializer.Deserialize<OAuthToken>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<OAuthVerify> GetOAuthVerify(string token)
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri(OAUTH_TOKEN_URL) };
            client.DefaultRequestHeaders.Add("User-Agent", "Basic");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await client.GetAsync("/oauth/verify");
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonSerializer.Deserialize<OAuthVerify>(result);
        }

        public async Task<OAuthToken> GetTokenFromRefreshToken(string refreshToken, string version = "")
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri(OAUTH_TOKEN_URL) };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _authString(version));

            var response = await client.PostAsync("/oauth/token", new StringContent("grant_type=refresh_token&refresh_token=" + refreshToken, Encoding.UTF8, "application/x-www-form-urlencoded"));
            return JsonSerializer.Deserialize<OAuthToken>(response.Content.ReadAsStringAsync().Result);
        }
    }
}
