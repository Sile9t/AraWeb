using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IOccupancyService
    {
        Task<IEnumerable<OccupancyDto>> GetAllOccupanciesAsync(bool trackChanges);
        Task<IEnumerable<OccupancyDto>> GetOccupanciesForUserAsync(Guid userId, 
            bool trackChanges);
        Task<IEnumerable<OccupancyDto>> GetOccupanciesForApartmentAsync(Guid apartId, 
            bool trackChanges);
        Task<OccupancyDto> GetOccupancyByIdAsync(Guid occupId, bool trackChanges);
        Task<IEnumerable<OccupancyDto>> GetOccupanciesByIdsAsync(IEnumerable<Guid> occupIds,
            bool trackChanges);
        Task<OccupancyDto> CreateOccupancyForUserAndApartmentAsync(Guid userId, Guid apartId, 
            OccupancyForCreationDto occupancyDto, bool userTrackChanges, bool apartTrackChanges,
            bool occupTrackChanges);
        Task<IEnumerable<OccupancyDto>> CreateOccupancyCollectionForUserAndApartmentAsync(
            Guid userId, Guid apartId, IEnumerable<OccupancyForCreationDto> occupForCreate, 
            bool userTrackChanges, bool apartTrackChanges, bool occupTrackChanges);
        Task DeleteOccupancyAsync(Guid occupId, bool trackChanges);
        Task DeleteOccupancyCollectionAsync(IEnumerable<Guid> ids,
            bool trackChanges);
        Task UpdateOccupancyAsync(Guid apartId, Guid occupId, OccupancyForUpdateDto occupancyDto,
            bool apartTrackChanges, bool occupTrackChanges);
        Task<(OccupancyForUpdateDto occupToPatch, Occupancy occup)> GetOccupancyForPatchAsync(
            Guid occupId, OccupancyForUpdateDto occupForPatch, bool trackChanges);
        Task SaveChangesForPatchAsync(OccupancyForUpdateDto occupToPatch, Occupancy occup);
    }
}
