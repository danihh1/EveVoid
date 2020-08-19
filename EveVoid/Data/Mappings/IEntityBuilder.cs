using Microsoft.EntityFrameworkCore;

namespace EveVoid.Data.Mappings
{
    public interface IEntityBuilder<T>
    {
        void Build(ModelBuilder modelBuilder);
    }
}