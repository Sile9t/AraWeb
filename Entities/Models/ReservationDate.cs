using Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ReservationDate
    {
        public DateTime Date { get; set; }

        public decimal Cost { get; set; }
        public decimal ExtraCharge { get; set; }

        [ForeignKey(nameof(Apartment))]
        public Guid ApartmentId { get; set; }
        public Apartment? Apartment { get; set; }
        [ForeignKey(nameof(User))]
        public Guid? ReservedById { get; set; }
        public User? ReservedBy {  get; set; }
    }
}
