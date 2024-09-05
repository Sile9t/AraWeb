using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public record UserDto
    {
        [Display(Name = "First Name")]
        public string? FirstName { get; init; }
        [Display(Name = "Last Name")]
        public string? LastName { get; init; }
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; init; }
    }
}
