using System;

namespace EveVoid.Models.Shared
{
    public interface IHasCreationTime
    {
        public DateTime CreationDate { get; set; }
    }
}
