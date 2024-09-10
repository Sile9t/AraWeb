namespace Contracts
{
    public interface IOccupancyRepository
    {
        Task<IEnumerable<OccupancyDto>> GetAllOccupanciesAsync(bool trackChanges);
        Task<IEnumerable<OccupancyDto>> GetOccupanciesForUserAsync(string userId, 
            bool trackChanges);
        Task<IEnumerable<OccupancyDto>> GetOccupanciesForApartmentAsync(string userId,
            bool trackChanges);
        Task<OccupancyDto> GetOccupancyById(int id, trackChanges)
    }
}
