namespace Entities.Models
{
    public class DateState
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateStateId DateStateId { get; set; }

        public ICollection<ReservationDate>? Dates { get; set; }
    }
}
