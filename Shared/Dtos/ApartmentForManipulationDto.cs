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

        [Required(ErrorMessage = "Capacity square field is required!")]
        public double CapacitySquare { get; init; }

        [Required(ErrorMessage = "Guests count field is required!")]
        public int GuestsCount { get; init; }

        [Required(ErrorMessage = "Beds count field is required!")]
        public int BedsCount { get; init; }

        [Required(ErrorMessage = "Rooms count field is required!")]
        public int RoomsCount { get; init; }

        public double Rate { get; init; }
        public long ReviewsCount { get; init; }
    }

    public record ApartmentForCreationDto : ApartmentForManipulationDto;
    public record ApartmentForUpdateDto : ApartmentForManipulationDto;
}
