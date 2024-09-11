using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public abstract record OccupancyForManipulationDto
    {
        public DateTime CreatedOn { get; init; } = DateTime.Now;
        public DateTime OccupancyDate { get; init; }
        public DateTime EvictionDate { get; init; }

        public decimal TotalCost { get; init; }
        public int OccupStateId { get; init; } = 0;

        public string? ReservedById { get; set; }
        public Guid? ApartmentId { get; set; }
    }

    public record OccupancyForCreationDto : OccupancyForManipulationDto;
    public record OccupancyForUpdateDto : OccupancyForManipulationDto;
}
