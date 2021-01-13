using AirportSimulationSystem.Database.Entities;
using Microsoft.EntityFrameworkCore; 

namespace AirportSimulationSystem.Database
{
    public class AirportContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<Airplane> Airplanes { get; set; }

        public AirportContext(DbContextOptions<AirportContext> options) : base(options)
        {
            //Database.EnsureDeleted(); 
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>()
                .HasOne(x => x.Airplane)
                .WithMany(x => x.Flights)
                .HasForeignKey(x => x.AirplaneId)
                .IsRequired(true);

            modelBuilder.Entity<Flight>()
                .HasOne(x => x.City)
                .WithMany(x => x.Flights)
                .HasForeignKey(x => x.CityId)
                .IsRequired(true);

            modelBuilder.Entity<Flight>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Airplane>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<City>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
