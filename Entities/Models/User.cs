using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }
        [Required(ErrorMessage = "Phone number is required!")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }
}
