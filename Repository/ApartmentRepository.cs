using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;

namespace Repository
{
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Apartment>> GetAllApartmentsAsync(ApartmentParameters apartmentParameters,
            bool trackChanges)
        {
            var apartments = await FindAll(trackChanges)
                .OrderBy(a => a.Name)
                .Paginate(apartmentParameters)
                .ToListAsync();

            return apartments;
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges) =>
            await FindByCondition(a => ids.Contains(a.Id), trackChanges)
            .ToListAsync();

        public async Task<Apartment> GetApartmentByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(a => a.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateApartment(Apartment apartment) =>
            Create(apartment);

        public void DeleteApartment(Apartment apartment) =>
            Delete(apartment);
    }
}
