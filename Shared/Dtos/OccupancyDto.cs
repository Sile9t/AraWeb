using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record OccupancyDto
    {
        public Guid Id { get; init; }

        public DateTime CreatedOn { get; init; }
        [DataType(DataType.Date)]
        public DateTime OccupancyDate { get; init; }
        [DataType(DataType.Date)]
        public DateTime EvictionDate { get; init; }

        public decimal TotalCost { get; init; }
        public int OccupStateId { get; init; } = 0;
        
        public string? ReservedById { get; init; }
        public Guid? ApartmentId { get; init; }
    }
}
