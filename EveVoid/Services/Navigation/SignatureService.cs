using EveVoid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Services.Navigation
{
    public class SignatureService
    {
        public EveVoidContext _context { get; set; }

        public SignatureService(EveVoidContext context)
        {
            _context = context;
        }


    }
}
