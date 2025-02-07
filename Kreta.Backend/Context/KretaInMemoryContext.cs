using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Context
{
    public class KretaInMemoryContext : KretaContext
    {
        public KretaInMemoryContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
