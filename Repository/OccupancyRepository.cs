using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class OccupancyRepository : RepositoryBase<Occupancy>, IOccupancyRepository
    {
        public OccupancyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Occupancy>> GetAllOccupanciesAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();
        
        public async Task<IEnumerable<Occupancy>> GetOccupanciesForApartmentAsync(Guid apartId, bool trackChanges)
        {
            var occupancies = await FindByCondition(o => o.ApartmentId!.Equals(apartId),
                trackChanges).ToListAsync();

            return occupancies;
        }

        public async Task<IEnumerable<Occupancy>> GetOccupanciesForUserAsync(Guid userId, bool trackChanges)
        {
            var occupancies = await FindByCondition(o => o.ReservedById!.Equals(userId),
                trackChanges).ToListAsync();

            return occupancies;
        }

        public async Task<Occupancy?> GetOccupancyByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(o => o.Id.Equals(id), trackChanges)
                .SingleOrDefaultAsync();

        public void CreateOccupancy(Occupancy occupancy) =>
            Create(occupancy);

        public void DeleteOccupancy(Occupancy occupancy) =>
            Delete(occupancy);
        
    }
}
