using Entities.Models;

namespace Contracts
{
    public interface IApartmentRepository
    {
        IEnumerable<Apartment> GetAllApartments(bool trackChanges);
        //Apartment GetApartmentById(Guid id, bool trackChanges);

    }
}
