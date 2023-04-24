using LocationFacileBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace LocationFacileBackend
{
    public class LocationFacileDBContext : DbContext
    {
        public LocationFacileDBContext(DbContextOptions<LocationFacileDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<House>()
            .Property(e => e.Images)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
        }
        public DbSet<House> Houses { get; set; }
    }
}
