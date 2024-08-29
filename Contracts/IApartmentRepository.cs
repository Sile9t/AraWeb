using Entities.Models;

namespace Contracts
{
    public interface IApartmentRepository
    {
        IEnumerable<Apartment> GetAllApartments(bool trackChanges);
        IEnumerable<Apartment> GetApartmentsByIds(IEnumerable<Guid> ids,
            bool trackChanges);
        Apartment GetApartmentById(Guid id, bool trackChanges);
        void CreateApartment(Apartment apartment);
        void DeleteApartment(Apartment apartment);
    }
}
