﻿using Entities.LinkModels;
using Entities.Models;
using Shared.Dtos;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IApartmentService
    {
        Task<(LinkResponse linkResponse, MetaData metaData)> GetAllApartmentsAsync(
            LinkParameters linkParameters, bool trackChanges);
        Task<IEnumerable<ApartmentDto>> GetApartmentsByIdsAsync(IEnumerable<Guid> ids, 
            bool trackChanges);
        Task<ApartmentDto> GetApartmentByIdAsync(Guid id, bool trackChanges);
        Task<IEnumerable<ApartmentDto>> GetApartmentsForOwnerAsync(string ownerId, bool trackChanges);
        Task<ApartmentDto> CreateApartmentForUserAsync(string userId,
            ApartmentForCreationDto apartmentForCreation, bool trackChanges);
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
