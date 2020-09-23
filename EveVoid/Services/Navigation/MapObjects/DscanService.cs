using EveVoid.Data;
using EveVoid.Models.Navigation.MapObjects;
using System.Collections.Generic;
using System.Linq;

namespace EveVoid.Services.Navigation.MapObjects
{
    public class DscanService : IDscanService
    {
        public EveVoidContext _context { get; set; }
        public ISolarSystemService _solarSystemService { get; set; }

        public DscanService(EveVoidContext context,
            ISolarSystemService solarSystemService)
        {
            _context = context;
            _solarSystemService = solarSystemService;
        }

        public void Insert(Dscan dscan)
        {
            _context.Dscans.Add(dscan);
            _context.SaveChanges();
        }

        public void Update(Dscan dscan)
        {
            _context.Update(dscan);
            _context.SaveChanges();
        }

        public void Delete(int dscanId)
        {
            var dscan = GetById(dscanId);
            _context.Remove(dscan);
            _context.SaveChanges();
        }

        public Dscan GetById(int dscanId)
        {
            var dscan = _context.Dscans.FirstOrDefault(x => x.Id == dscanId);
            return dscan;
        }
    }
}
