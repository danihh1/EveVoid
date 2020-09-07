using EveVoid.Models.Navigation;
using System.Collections.Generic;

namespace EveVoid.Services.Navigation
{
    public interface ISignatureService
    {
        //Signature GetOrAddWormholeByOriginAndDestoId(int originId, int destoId, int maskId, int jumpedSigId);
        Signature GetBySignatureId(int id);
        void Insert(Signature signature, bool commit = false);
        void Update(Signature signature, bool commit = false);
        void Delete(int id, bool commit = false);
        List<WormholeType> GetWormholeTypes();
        WormholeType GetByTypeName(string name);
    }
}