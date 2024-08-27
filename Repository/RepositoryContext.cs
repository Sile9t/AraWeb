using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Bogus;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext()
        {
        }

        public RepositoryContext(DbContextOptions options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ReservationDate>(entity =>
            {
                entity.HasKey(e => e.Date);
            });

            modelBuilder.Entity<Occupancy>(entity =>
            {
                entity.HasOne(o => o.Apartment)
                    .WithMany(a => a.Occupancies)
                    .HasForeignKey(o => o.ApartmentId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(o => o.ReservedBy)
                    .WithMany(u => u.Occupancies)
                    .HasForeignKey(o => o.ReservedById)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasMany(o => o.ReservedDates)
                    .WithOne(d => d.Occupancy)
                    .HasForeignKey(d => d.OccupancyId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            DataGenerator.InitBogusData();
            modelBuilder.Entity<User>().HasData(DataGenerator.Users);
            modelBuilder.Entity<Apartment>().HasData(DataGenerator.Apartments);
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Apartment>? Apartments{ get; set; }
        public DbSet<ReservationDate>? ReservationDates { get; set; }
        public DbSet<Occupancy>? Occupancies{ get; set; }
    }
}
