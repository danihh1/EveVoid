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
        EsiCharacter GetEsiCharacterWithActiveToken(string mainToken, string esiToken);
        EsiCharacter UpdateEsiCharacter(string mainToken, EsiCharacterDto dto);
    }
}