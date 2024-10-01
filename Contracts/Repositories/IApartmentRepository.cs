using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts.Repositories
{
    public interface IApartmentRepository
    {
        Task<IEnumerable<Apartment>> GetAllApartmentsAsync(bool trackChanges);
        Task<PagedList<Apartment>> GetAllApartmentsForQueryAsync(ApartmentParameters apartmentParameters,
            bool trackChanges);
        Task<IEnumerable<Apartment>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges);
        Task<IEnumerable<Apartment>> GetApartmentsForOwnerAsync(Guid ownerId, bool trackChanges);
        Task<Apartment?> GetApartmentByIdAsync(Guid id, bool trackChanges);
        void CreateApartment(Apartment apartment);
        void DeleteApartment(Apartment apartment);
    }
}
