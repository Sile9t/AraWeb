using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record ReservationDateDto
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; init; }
        public Guid ApartmentId { get; init; }
        public int DateStateId { get; init; }

        public decimal Cost { get; init; }
        public decimal ExtraCharge { get; init; }
        public Guid? OccupancyId { get; init; }
    }
}
