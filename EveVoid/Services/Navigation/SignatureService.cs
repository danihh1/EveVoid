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

        public Signature GetBySignatureId(int id)
        {
            return _context.Signatures.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Signature signature, bool commit = false)
        {
            _context.Signatures.Add(signature);
            if (commit)
            {
                _context.SaveChanges();
            }
        }

        public void Update(Signature signature, bool commit = false)
        {
            _context.Update(signature);
            if (commit)
            {
                _context.SaveChanges();
            }
        }

        public void Delete(int id, bool commit = false)
        {
            var sig = _context.Signatures.FirstOrDefault(x => x.Id == id);
            if (sig.DestinationId != null)
            {
                var dest = sig.Destination;
                dest.DestinationId = null;
                sig.DestinationId = null;
                Update(dest);
                Update(sig, commit: true);
                _context.Signatures.Remove(dest);
            }
            _context.Signatures.Remove(sig);
            if (commit)
            {
                _context.SaveChanges();
            }
        }

        public Signature GetSignatureByWormholeOriginAndDesto(int originId, int destoId, int maskId)
        {
            var system = _solarSystemService.GetSystemById(originId);
            return system.Signatures.FirstOrDefault(x => x.SignatureType == SignatureType.Wormhole && x.Destination.SystemId == destoId && x.MaskId == maskId);
        }

        public List<WormholeType> GetWormholeTypes()
        {
            return _context.WormholeTypes.ToList();
        }

        public WormholeType GetByTypeName(string name)
        {
            return _context.WormholeTypes.FirstOrDefault(x => x.Name == name);
        }

        //public Wormhole GetOrAddWormhole(int originId, int destoId, int maskId, int jumpedSigId)
        //{
        //    var sig = _context.Signatures.FirstOrDefault(x => x.SystemId == originId && x.Id == jumpedSigId);
        //    if (jumpedSigId == 0)
        //    {
        //        sig = _context.Signatures.FirstOrDefault(x => x.SystemId == originId && x.LeadsToId != null && x.LeadsTo.SystemId == destoId);
        //    }
        //    if (sig == null)
        //    {
        //        var origin = _solarSystemService.GetSystemById(originId);
        //        origin.Signatures.Add(sig = new Signature
        //        {
        //            Name = "Name",
        //            ExpiryDate = DateTime.UtcNow.AddDays(1),
        //            SignatureId = "???",
        //            SignatureType = SignatureType.Wormhole,
        //            MaskId = maskId
        //        });
        //        _context.SaveChanges();
        //        if (destoId > 0)
        //        {
        //            var desto = _solarSystemService.GetSystemById(destoId);
        //            var destoSig = new Signature
        //            {
        //                Name = "Name",
        //                ExpiryDate = DateTime.UtcNow.AddDays(1),
        //                SignatureId = "???",
        //                SignatureType = SignatureType.Wormhole,
        //                MaskId = maskId
        //            };
        //            desto.Signatures.Add(destoSig);
        //            _context.SaveChanges();
        //            destoSig.LeadsToId = sig.Id;
        //            sig.LeadsToId = destoSig.Id;
        //            _context.SaveChanges();
        //        }
        //    }
        //    return sig;
        //}
    }
}
