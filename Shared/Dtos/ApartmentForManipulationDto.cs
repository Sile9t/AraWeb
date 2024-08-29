using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public abstract record ApartmentForManipulationDto
    {
        [MaxLength(80, ErrorMessage = "Maximum length for Name is 80 characters")]
        public string? Name { get; init; }

        [Required(ErrorMessage = "Address field is required!")]
        [MinLength(10, ErrorMessage = "Minimum length for Address is 10 characters")]
        public string? Address { get; init; }

        [Range(10, double.MaxValue, ErrorMessage = "Capacity square is required and it can't be lower than 10")]
        public double CapacitySquare { get; init; }

        [Range(1, int.MaxValue, ErrorMessage = "Guests count is required and it can't be lower than 10")]
        public int GuestsCount { get; init; }

        [Range(1, int.MaxValue, ErrorMessage = "Beds count is required and it can't be lower than 10")]
        public int BedsCount { get; init; }

        [Range(1, int.MaxValue, ErrorMessage = "Room count is required and it can't be lower than 10")]
        public int RoomsCount { get; init; }

        public double Rate { get; init; }
        public long ReviewsCount { get; init; }
    }

    public record ApartmentForCreationDto : ApartmentForManipulationDto;
    public record ApartmentForUpdateDto : ApartmentForManipulationDto;
}
