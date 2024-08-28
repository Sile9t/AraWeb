using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record ApartmentDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? Address { get; init; }
        public double CapacitySquare { get; init; }
        public int GuestsCount { get; init; }
        public int BedsCount { get; init; }
        public int RoomsCount { get; init; }
        public double Rate { get; init; }
        public long ReviewsCount { get; init; }
    }
}
