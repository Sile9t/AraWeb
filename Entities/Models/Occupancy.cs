using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Occupancy
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime OccupancyDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EvictionDate { get; set; }

        public decimal TotalCost { get; set; }

        [ForeignKey(nameof(User))]
        public Guid ReservedById { get; set; }
        public User? ReservedBy {  get; set; }
        [ForeignKey(nameof(Apartment))]
        public Guid ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public ICollection<ReservationDate>? ReservedDates { get; set; }
    }
}
