using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Models.Responses
{
    public class OAuthVerify
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }
    }
}
