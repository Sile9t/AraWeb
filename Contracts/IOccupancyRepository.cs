using Entities.Models;

namespace Contracts
{
    public interface IOccupancyRepository
    {
        Task<IEnumerable<Occupancy>> GetAllOccupanciesAsync(bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesForUserAsync(Guid userId, 
            bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesForApartmentAsync(Guid apartId,
            bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesByIds(IEnumerable<Guid> ids, bool trackChanges);
        Task<Occupancy?> GetOccupancyByIdAsync(Guid id, bool trackChanges);
        void CreateOccupancy(Occupancy occupancy);
        void DeleteOccupancy(Occupancy occupancy);
    }
}
