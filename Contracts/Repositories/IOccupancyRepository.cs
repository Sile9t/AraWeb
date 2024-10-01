using Entities.Models;

namespace Contracts.Repositories
{
    public interface IOccupancyRepository
    {
        Task<IEnumerable<Occupancy>> GetAllOccupanciesAsync(bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesForUserAsync(Guid userId,
            bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesForApartmentAsync(Guid apartId,
            bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<Occupancy?> GetOccupancyByIdAsync(Guid id, bool trackChanges);
        void CreateOccupancy(Guid? userId, Guid? apartId, Occupancy occupancy);
        void DeleteOccupancy(Occupancy occupancy);
    }
}
