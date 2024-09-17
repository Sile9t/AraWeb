using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class ReservationDate
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public Guid ApartmentId { get; set; }

        public double Cost { get; set; }
        public double ExtraCharge { get; set; }
        public DateStateId DateStateId { get; set; }
        public DateState? DateState { get; set; }

        [ForeignKey(nameof(Occupancy))]
        public Guid? OccupancyId { get; set; }
        public virtual Occupancy? Occupancy { get; set; }

        //public ReservationDate(DateTime date, Guid apartId)
        //{
        //    Date = date;
        //    ApartmentId = apartId;
        //    DateStateId = DateStateId.Empty;
        //}
    }
}
