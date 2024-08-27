using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Apartment>? Apartments{ get; set; }
        public DbSet<ReservationDate>? ReservationDates { get; set; }
        public DbSet<Occupancy>? Occupancies{ get; set; }
    }
}
