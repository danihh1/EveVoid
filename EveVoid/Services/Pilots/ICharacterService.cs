using EveVoid.Dto;
using EveVoid.Models.Pilots;
using EveVoid.Models.Responses;

namespace EveVoid.Services.Pilots
{
    public interface ICharacterService
    {
        MainCharacter CreateOrUpdateMain(MainLoginDto dto);
        MainCharacter GetMainCharacterByToken(string token);
        EsiCharacter AddOrUpdateEsiCharacterToMainToken(string token, OAuthToken authToken, OAuthVerify authVerify);
    }
}