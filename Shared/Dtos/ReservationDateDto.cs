using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record ReservationDateDto
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; init; }
        public Guid ApartmentId { get; init; }
        public int DateStateId { get; init; }

        public double Cost { get; init; }
        public double ExtraCharge { get; init; }
        public Guid? OccupancyId { get; init; }
    }
}
