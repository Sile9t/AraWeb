using Shared.Dtos;

namespace Contracts
{
    public interface IApartmentRepository
    {
        IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges);
        //ApartmentDto GetApartmentById(Guid id, bool trackChanges);

    }
}
