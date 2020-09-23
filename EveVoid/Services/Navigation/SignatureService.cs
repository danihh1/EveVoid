using EveVoid.Data;
using EveVoid.Dto;
using EveVoid.Models.Navigation;
using EveVoid.Models.Navigation.Matrix;
using EveVoid.Services.Navigation.MapObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation
{
    public class SignatureService : ISignatureService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }
        public IRouteService _routeService { get; set; }


        public SignatureService(EveVoidContext context,
            ISolarSystemService solarSystemService, 
            IRouteService routeService)
        {
            _context = context;
            _solarSystemService = solarSystemService;
            _routeService = routeService;
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
                _routeService.RemoveAdjacency(sig.SystemId, dest.SystemId, sig.MaskId);
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

        public void WormholeSigUpdate(SignatureDto dto, Signature sig, int maskId)
        {
            if (dto.SignatureType == SignatureType.Wormhole)
            {
                sig.MassIndicator = dto.MassIndicator;
                if (sig.TimeRemainingIndicator != dto.TimeRemainingIndicator)
                {
                    switch (dto.TimeRemainingIndicator)
                    {
                        case TimeRemainingIndicator.EoL:
                            {
                                if (sig.ExpiryDate > DateTime.UtcNow.AddHours(4))
                                {
                                    sig.ExpiryDate = DateTime.UtcNow.AddHours(4);
                                }
                                break;
                            }
                        case TimeRemainingIndicator.Unset:
                            {
                                var baseHours = 24;
                                if (sig.WormholeType != null)
                                {
                                    baseHours = int.Parse(Regex.Replace(sig.WormholeType.Duration, "[^0-9]+", string.Empty));
                                    sig.ExpiryDate = sig.CreationDate.AddHours(baseHours);
                                }
                                break;
                            }
                    }
                }
                sig.TimeRemainingIndicator = dto.TimeRemainingIndicator;
                sig.WormholeTypeId = dto.WormholeTypeId;
                Update(sig, commit: true);
                if (dto.DestinationSystemId.HasValue)
                {
                    if (sig.DestinationId.HasValue && sig.Destination.SystemId != dto.DestinationSystemId)
                    {
                        Delete(sig.DestinationId.Value);
                        sig.DestinationId = null;
                        Update(sig, commit: true);
                    }
                    var desto = _solarSystemService.GetSystemById(dto.DestinationSystemId.Value);
                    var origin = _solarSystemService.GetSystemById(dto.SystemId);
                    var destoSig = desto.Signatures.FirstOrDefault(x => x.Id == sig.DestinationId);
                    if (destoSig == null)
                    {
                        destoSig = new Signature
                        {
                            SignatureId = "???",
                            ExpiryDate = sig.ExpiryDate,
                            Name = "",
                            SignatureType = SignatureType.Wormhole,
                            MaskId = maskId,
                            WormholeTypeId = GetByTypeName("????").Id
                        };
                        desto.Signatures.Add(destoSig);
                        _routeService.AddAdjacency(sig.SystemId, desto.Id, sig.MaskId, 
                            desto.Class > 0 || origin.Class > 0 ? 10 : // J Space Connection = 10
                            desto.Security < 0.5 || origin.Security < 0.5 ? 100 : // Null/Low sec connection = 100
                            1); // Hisec to Hisec = 1
                        _solarSystemService.UpdateSystem(desto);
                    }
                    if (dto.WormholeType != "K162" && dto.WormholeType != "????")
                    {
                        destoSig.WormholeTypeId = GetByTypeName("K162").Id;
                    }
                    sig.DestinationId = destoSig.Id;
                    destoSig.DestinationId = sig.Id;
                    destoSig.MassIndicator = sig.MassIndicator;
                    destoSig.TimeRemainingIndicator = sig.TimeRemainingIndicator;
                    destoSig.ExpiryDate = sig.ExpiryDate;
                    _solarSystemService.UpdateSystem(desto);
                }
                else
                {
                    if (sig.DestinationId.HasValue)
                    {
                        Delete(sig.DestinationId.Value);
                        sig.DestinationId = null;
                    }
                }
            }
            else
            {
                if (sig.DestinationId.HasValue)
                {
                    Delete(sig.DestinationId.Value);
                    sig.DestinationId = null;
                }
                sig.WormholeTypeId = null;
            }
            Update(sig, commit: true);
        }
    }
}
