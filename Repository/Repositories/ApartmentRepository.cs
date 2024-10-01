using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Repositories.Extensions;
using Shared.RequestFeatures;

namespace Repository.Repositories
{
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Apartment>> GetAllApartmentsAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<PagedList<Apartment>> GetAllApartmentsForQueryAsync(ApartmentParameters apartmentParameters,
            bool trackChanges)
        {
            var apartments = await FindAll(trackChanges)
                .Filter(apartmentParameters)
                .Search(apartmentParameters.SearchTerm!)
                .Sort(apartmentParameters.OrderBy!)
                .ToListAsync();

            var count = apartments.Count();

            var apartmentsForPage = await FindAll(trackChanges)
                .OrderBy(a => a.Name)
                .Paginate(apartmentParameters)
                .ToListAsync();

            return new PagedList<Apartment>(apartmentsForPage, count, apartmentParameters.PageNumber,
                apartmentParameters.PageSize);
        }

        public async Task<IEnumerable<Apartment>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges) =>
            await FindByCondition(a => ids.Contains(a.Id), trackChanges)
            .ToListAsync();

        public async Task<IEnumerable<Apartment>> GetApartmentsForOwnerAsync(Guid ownerId, bool trackChanges)
        {
            var apartments = await FindByCondition(a => a.OwnerId.Equals(ownerId), trackChanges)
                .ToListAsync();

            return apartments;
        }

        public async Task<Apartment?> GetApartmentByIdAsync(Guid id, bool trackChanges) =>
            await FindByCondition(a => a.Id.Equals(id), trackChanges)
                .SingleOrDefaultAsync();

        public void CreateApartment(Apartment apartment) =>
            Create(apartment);

        public void DeleteApartment(Apartment apartment) =>
            Delete(apartment);
    }
}
