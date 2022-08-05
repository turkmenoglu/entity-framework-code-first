using EFCodeFirst.Model.Entity;
using System.Data.Entity;

namespace EFCodeFirst.Model.Context
{
    class OrnekVeriDbContext : DbContext
    {
        public DbSet<OrnekTablo> OrnekTablos { get; set; }
    }
}
