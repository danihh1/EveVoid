using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EveVoid.Dto
{
    public class MainLoginDto
    {
        public int CharacterId { get; set; }
        public string CharacterName { get; set; }
        public string AccessToken { get; set; }
    }
}
