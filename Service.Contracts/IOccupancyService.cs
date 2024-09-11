using Shared.Dtos;

namespace Service.Contracts
{
    public interface IOccupancyService
    {
        Task<OccupancyDto> GetAllOccupanciesAsync(bool trackChanges);
        Task<OccupancyDto> GetOccupanciesForUserAsync(Guid userId, bool trackChanges);
        Task<OccupancyDto> GetOccupanciesForApartmentAsync(Guid apartId, bool trackChanges);
        Task<OccupancyDto> CreateOccupancyForApartmentAsync(Guid apartId, 
            OccupancyForCreationDto occupancyDto, bool trackChanges);
    }
}
