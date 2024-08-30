using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IApartmentService
    {
        Task<IEnumerable<ApartmentDto>> GetAllApartmentsAsync(bool trackChanges);
        Task<IEnumerable<ApartmentDto>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids, 
            bool trackChanges);
        Task<ApartmentDto> GetApartmentByIdAsync(Guid id, bool trackChanges);
        Task<ApartmentDto> CreateApartmentAsync(ApartmentForCreationDto apartmentForCreation);
        Task<(IEnumerable<ApartmentDto> apartments, string ids)> CreateApartmentCollectionAsync(
            IEnumerable<ApartmentForCreationDto> apartmentCollection);
        Task DeleteApartmentAsync(Guid id, bool trackChanges);
        Task UpdateApartmentAsync(Guid id, ApartmentForUpdateDto apartmentForUpdate, 
            bool trackChanges);
        Task<(ApartmentForUpdateDto apartmentToPatch, Apartment apartmentEntity)> GetApartmentForPatchAsync(
            Guid id, bool trackChanges);
        Task SaveChangesForPatchAsync(ApartmentForUpdateDto apartmentToPatch,
            Apartment apartmentEntity);
    }
}
