using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Dto
{
    public class EsiLoginDto
    {
        public string MainCharacterToken { get; set; }
        public string AccessCode { get; set; }
        //public int CharacterId { get; set; }
        //public string CharacterName { get; set; }
        //public string AccessToken { get; set; }
        //public string RefreshToken { get; set; }
        //public int Expiry { get; set; }
    }
}
