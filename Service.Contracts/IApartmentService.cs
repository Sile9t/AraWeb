using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IApartmentService
    {
        IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges);
        IEnumerable<ApartmentDto> GetApartmentsByIds(IEnumerable<Guid> ids, 
            bool trackChanges);
        ApartmentDto GetApartmentById(Guid id, bool trackChanges);
        ApartmentDto CreateApartment(ApartmentForCreationDto apartmentForCreation);
        (IEnumerable<ApartmentDto> apartments, string ids) CreateApartmentCollection(
            IEnumerable<ApartmentForCreationDto> apartmentCollection);
        void DeleteApartment(Guid id, bool trackChanges);
        void UpdateApartment(Guid id, ApartmentForUpdateDto apartmentForUpdate, 
            bool trackChanges);
        (ApartmentForUpdateDto apartmentToPatch, Apartment apartmentEntity) GetApartmentForPatch(
            Guid id, bool trackChanges);
        void SaveChangesForPatch(ApartmentForUpdateDto apartmentToPatch,
            Apartment apartmentEntity);
    }
}
