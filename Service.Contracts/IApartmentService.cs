using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IApartmentService
    {
        IEnumerable<Apartment> GetAllApartments(bool trackChanges);
    }
}
