using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExperyTime { get; set; }

        public virtual ICollection<Apartment>? Apartments { get; set; }
        public virtual ICollection<Occupancy>? Occupancies { get; set; }
    }
}
