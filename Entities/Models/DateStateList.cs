namespace Entities.Models
{
    public class DateStateList
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateState DateStateId { get; set; }

        public ICollection<ReservationDate>? Dates { get; set; }
    }
}
