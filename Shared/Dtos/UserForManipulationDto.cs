﻿using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos
{
    public abstract record UserForManipulationDto
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        [Required(ErrorMessage = "UserName is required")]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; init; }
        [Required(ErrorMessage = "Phone number is required")]
        public string? PhoneNumber { get; init; }
        public ICollection<string>? Roles { get; init; }
    }

    public record UserForRegistrationDto : UserForManipulationDto { }
    public record UserForUpdateDto : UserForManipulationDto { }

    public record UserForAuthenticationDto
    {
        [Required(ErrorMessage = "User namem is required!")]
        public string? UserName { get; init; }
        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; init; }
    }
}
