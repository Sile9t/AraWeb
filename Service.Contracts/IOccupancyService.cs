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
        Task<OccupancyDto> CreateOccupancyForUserAndApartmentAsync(Guid userId, Guid apartId, 
            OccupancyForCreationDto occupancyDto, bool userTrackChanges, bool apartTrackChanges,
            bool occupTrackChanges);
        Task DeleteOccupancy(Guid userId, Guid apartId, Guid id, bool trackChanges);
        Task UpdateOccupancy(Guid apartId, Guid id, OccupancyForUpdateDto occupancyDto,
            bool apartTrackChanges, bool occupTrackChanges);
    }
}
