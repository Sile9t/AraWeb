using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record OccupancyDto
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime OccupancyDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EvictionDate { get; set; }

        public decimal TotalCost { get; set; }
        public int OccupStateId { get; set; } = 0;
        
        public string? ReservedById { get; set; }
        public Guid? ApartmentId { get; set; }
    }
}
