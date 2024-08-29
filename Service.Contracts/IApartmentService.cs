using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IApartmentService
    {
        IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges);
        ApartmentDto GetApartmentById(Guid id, bool trackChanges);
        ApartmentDto CreateApartment(ApartmentForCreationDto apartmentForCreation);
    }
}
