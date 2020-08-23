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

        public Signature GetOrAddWormholeByOriginAndDestoId(int originId, int destoId)
        {
            var sig = _context.Signatures.FirstOrDefault(x => x.SystemId == originId && x.LeadsToId != null && x.LeadsTo.SystemId == destoId);
            if (sig == null)
            {
                var origin = _solarSystemService.GetSystemById(originId);
                var desto = _solarSystemService.GetSystemById(destoId);
                var destoSig = new Signature
                {
                    Name = "Name",
                    CreationDate = DateTime.Now,
                    ExpiryDate = DateTime.Now.AddDays(1),
                    SignatureId = "???",
                    SignatureType = SignatureType.Wormhole,
                };
                desto.Signatures.Add(destoSig);
                origin.Signatures.Add(sig = new Signature
                {
                    Name = "Name",
                    CreationDate = DateTime.Now,
                    ExpiryDate = DateTime.Now.AddDays(1),
                    SignatureId = "???",
                    SignatureType = SignatureType.Wormhole,
                });
                _context.SaveChanges();
                destoSig.LeadsToId = sig.Id;
                sig.LeadsToId = destoSig.Id;
                _context.SaveChanges();
            }
            return sig;
        }
    }
}
