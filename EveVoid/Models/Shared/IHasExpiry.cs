using System;

namespace EveVoid.Models.Shared
{
    public interface IHasExpiry
    {
        public DateTime ExpiryDate { get; set; }
    }
}