namespace Entities.Models
{
    public class OccupState
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public OccupStateId OccupStateId { get; set; }

        public ICollection<Occupancy>? Occupancies { get; set; }
    }
}
