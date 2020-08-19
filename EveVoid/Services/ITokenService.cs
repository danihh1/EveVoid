using EveVoid.Models.Responses;
using System.Threading.Tasks;

namespace EveVoid.Services
{
    public interface ITokenService
    {
        string GetAuthString(string version = "");
        Task<OAuthToken> GetOAuthToken(string code, string version = "");
        Task<OAuthVerify> GetOAuthVerify(string token);
        Task<OAuthToken> GetTokenFromRefreshToken(string refreshToken, string version = "");
    }
}