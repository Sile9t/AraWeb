using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repository.Bogus;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
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

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(u => u.PhoneNumber).IsRequired();
            });

            modelBuilder.Entity<ReservationDate>(entity => 
            {
                entity.HasKey(e => new { e.Date, e.ApartmentId});

                entity.Property(rd => rd.DateStateId)
                    .HasConversion<int>();

                entity.HasOne(rd => rd.DateState)
                    .WithMany(s => s.Dates)
                    .HasForeignKey(rd => rd.DateStateId);
            });

            modelBuilder.Entity<DateState>(entity =>
            {
                entity.Property(ds => ds.DateStateId)
                    .HasConversion<int>();

                entity.HasData(Enum.GetValues(typeof(DateStateId)).Cast<DateStateId>()
                    .Select(dsi => new DateState() { DateStateId = dsi, Name = dsi.ToString() }));
            });

            modelBuilder.Entity<Occupancy>(entity =>
            {
                entity.Property(o => o.OccupStateId)
                    .HasConversion<int>();

                entity.HasOne(o => o.State)
                    .WithMany(s => s.Occupancies)
                    .HasForeignKey(o => o.OccupStateId);
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

            modelBuilder.Entity<OccupState>(entity =>
            {
                entity.Property(os => os.OccupStateId)
                .HasConversion<int>();
                entity.HasData(Enum.GetValues(typeof(OccupStateId)).Cast<OccupStateId>()
                    .Select(osi => new OccupState() { OccupStateId = osi, Name = osi.ToString() }));
            });

            DataGenerator.InitBogusData();

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }

        public DbSet<Apartment>? Apartments{ get; set; }
        public DbSet<ReservationDate>? ReservationDates { get; set; }
        public DbSet<Occupancy>? Occupancies{ get; set; }
    }
}
