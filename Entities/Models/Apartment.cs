using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Apartment
    {
        [Column("ApartmentId")]
        public Guid Id { get; set; }

        [MaxLength(80, ErrorMessage = "Maximum length for Name is 80 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Address field is required!")]
        [MinLength(10, ErrorMessage = "Minimum length for Address is 10 characters")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Capacity square field is required!")]
        public double CapacitySquare { get; set; }

        [Required(ErrorMessage = "Guests count field is required!")]
        public int GuestsCount { get; set; }

        [Required(ErrorMessage = "Beds count field is required!")]
        public int BedsCount { get; set; }

        [Required(ErrorMessage = "Rooms count field is required!")]
        public int RoomsCount {  get; set; }

        public double Rate { get; set; }
        public long ReviewsCount { get; set; }

        [ForeignKey(nameof(User))]
        public Guid OwnerId { get; set; }
        public User? Owner { get; set; }
        public ICollection<ReservationDate>? ReservationDates { get; set; }
    }
}
