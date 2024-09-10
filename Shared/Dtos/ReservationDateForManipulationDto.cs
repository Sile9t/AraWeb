using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public abstract record ReservationDateForManipulationDto
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; init; }
        public Guid ApartmentId { get; init; }
        public int DateStateId { get; init; } = 0;

        public decimal Cost { get; init; }
        public decimal ExtraCharge { get; init; }
        public Guid? OccupancyId { get; init; }
    }

    public record ReservationDateForCreationDto : ReservationDateForManipulationDto;
    public record ReservationDateForUpdateDto : ReservationDateForManipulationDto;
}
