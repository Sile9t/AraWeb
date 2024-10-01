using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
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

        public async Task<IEnumerable<Occupancy>> GetOccupanciesByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges) =>
            await FindByCondition(o => ids.Contains(o.Id), trackChanges)
                .ToListAsync();

        public void CreateOccupancy(Guid? userId, Guid? apartId, Occupancy occupancy)
        {
            occupancy.ReservedById = userId;
            occupancy.ApartmentId = apartId;
            Create(occupancy);
        }

        public void DeleteOccupancy(Occupancy occupancy) =>
            Delete(occupancy);

    }
}
