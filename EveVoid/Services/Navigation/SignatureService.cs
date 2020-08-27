using EveVoid.Data;
using EveVoid.Models.Navigation;
using EveVoid.Services.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation
{
    public class SignatureService : ISignatureService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }

        public SignatureService(EveVoidContext context, 
            ISolarSystemService solarSystemService)
        {
            _context = context;
            _solarSystemService = solarSystemService;
        }

        public Signature GetOrAddWormholeByOriginAndDestoId(int originId, int destoId, int maskId)
        {
            var sig = _context.Signatures.FirstOrDefault(x => x.SystemId == originId && x.LeadsToId != null && x.LeadsTo.SystemId == destoId);
            if (sig == null)
            {
                var origin = _solarSystemService.GetSystemById(originId);
                var desto = _solarSystemService.GetSystemById(destoId);
                var destoSig = new Signature
                {
                    Name = "Name",
                    ExpiryDate = DateTime.Now.AddDays(1),
                    SignatureId = "???",
                    SignatureType = SignatureType.Wormhole,
                    MaskId = maskId
                };
                desto.Signatures.Add(destoSig);
                var potentialOriginSigs = origin.Signatures.Where(x => x.SignatureType == SignatureType.Wormhole && (x.WormholeTypeId == null || x.WormholeType.LeadsTo == desto.SystemType)).ToList();
                if (potentialOriginSigs.Count == 0)
                {
                    origin.Signatures.Add(sig = new Signature
                    {
                        Name = "Name",
                        ExpiryDate = DateTime.Now.AddDays(1),
                        SignatureId = "???",
                        SignatureType = SignatureType.Wormhole,
                        MaskId = maskId
                    });
                }
                else 
                {
                    sig = potentialOriginSigs.First();
                }
                _context.SaveChanges();
                destoSig.LeadsToId = sig.Id;
                sig.LeadsToId = destoSig.Id;
                _context.SaveChanges();
            }
            return sig;
        }
    }
}
