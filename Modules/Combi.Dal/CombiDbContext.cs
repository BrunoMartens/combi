using Combi.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Combi.Dal
{
    public class CombiDbContext: DbContext
    {
        public CombiDbContext(DbContextOptions<CombiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Demo> Demos { get; set; }
    }
}
