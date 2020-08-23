using EveVoid.Models.Navigation;

namespace EveVoid.Services.Navigation
{
    public interface ISignatureService
    {
        Signature GetOrAddWormholeByOriginAndDestoId(int originId, int destoId);
    }
}