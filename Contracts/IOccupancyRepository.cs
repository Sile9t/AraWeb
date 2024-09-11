using Entities.Models;

namespace Contracts
{
    public interface IOccupancyRepository
    {
        Task<IEnumerable<Occupancy>> GetAllOccupanciesAsync(bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesForUserAsync(string userId, 
            bool trackChanges);
        Task<IEnumerable<Occupancy>> GetOccupanciesForApartmentAsync(Guid apartId,
            bool trackChanges);
        Task<Occupancy> GetOccupancyById(int id, bool trackChanges);
        void CreateOccupancy(Guid apartId, Occupancy occupancy);
        void DeleteOccupancy(Guid id, bool trackChanges);
    }
}
