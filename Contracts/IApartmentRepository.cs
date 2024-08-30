using Entities.Models;

namespace Contracts
{
    public interface IApartmentRepository
    {
        Task<IEnumerable<Apartment>> GetAllApartmentsAsync(bool trackChanges);
        Task<IEnumerable<Apartment>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges);
        Task<Apartment> GetApartmentByIdAsync(Guid id, bool trackChanges);
        void CreateApartment(Apartment apartment);
        void DeleteApartment(Apartment apartment);
    }
}
