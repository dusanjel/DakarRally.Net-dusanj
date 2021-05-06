using Microsoft.EntityFrameworkCore;

namespace DakarRally.NetDusanj.Domain.Entity
{
    public class DakarRallyDBContext : DbContext
    {
        public DakarRallyDBContext(DbContextOptions<DakarRallyDBContext> options)
            : base(options)
        { }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Motorcycle> Motorcycles { get; set; }

        public DbSet<Truck> Trucks { get; set; }

        public DbSet<Race> Races { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .Property(b => b.Distance)
                .HasPrecision(18, 5);
        }
    }
}
