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
        public OccupStateId OccupStateId { get; set; }
        public virtual OccupState? State { get; set; }

        [ForeignKey(nameof(User))]
        public string? ReservedById { get; set; }
        public virtual User? ReservedBy {  get; set; }
        [ForeignKey(nameof(Apartment))]
        public Guid? ApartmentId { get; set; }
        public virtual Apartment? Apartment { get; set; }
        public ICollection<ReservationDate>? ReservedDates { get; set; }
    }
}
