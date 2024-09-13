using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.Dtos;

namespace Service
{
    internal class OccupancyService : IOccupancyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OccupancyService(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OccupancyDto>> GetAllOccupanciesAsync(bool trackChanges)
        {
            var occups = await _repository.Occupancy.GetAllOccupanciesAsync(trackChanges);

            var occupDtos = _mapper.Map<IEnumerable<OccupancyDto>>(occups);

            return occupDtos;
        }

        public async Task<IEnumerable<OccupancyDto>> GetOccupanciesForApartmentAsync(Guid apartId, 
            bool trackChanges)
        {
            var occups = await _repository.Occupancy
                .GetOccupanciesForApartmentAsync(apartId, trackChanges);

            var occupDtos = _mapper.Map<IEnumerable<OccupancyDto>>(occups);

            return occupDtos;
        }

        public async Task<IEnumerable<OccupancyDto>> GetOccupanciesForUserAsync(string userId, 
            bool trackChanges)
        {
            var occups = await _repository.Occupancy
                .GetOccupanciesForUserAsync(userId.ToString(), trackChanges);

            var occupDtos = _mapper.Map<IEnumerable<OccupancyDto>>(occups);

            return occupDtos;
        }

        public async Task UpdateOccupancy(Guid apartId, Guid id, 
            OccupancyForUpdateDto occupancyDto, bool apartTrackChanges, bool occupTrackChanges)
        {
            var apart = await GetApartIfExist(apartId, apartTrackChanges);

            var occup = await _repository.Occupancy
                .GetOccupancyByIdAsync(id, occupTrackChanges);
            _mapper.Map(occupancyDto, occup);

            await _repository.SaveAsync();
        }

        public async Task<OccupancyDto> CreateOccupancyForApartmentAsync(string userId, Guid apartId, 
            OccupancyForCreationDto occupancyDto, bool userTrackChanges, bool apartTrackChanges,
            bool occupTrackChanges)
        {
            var user = GetUserIfExist(userId, userTrackChanges);
            var apart = GetApartIfExist(apartId, apartTrackChanges);

            var occup = _mapper.Map<Occupancy>(occupancyDto);

            _repository.Occupancy.CreateOccupancy(apartId, occup);
            await _repository.SaveAsync();

            var occupDto = _mapper.Map<OccupancyDto>(occup);
            return occupDto;
        }

        public async Task DeleteOccupancy(string userId, Guid apartId, Guid id, 
            bool trackChanges)
        {
            var user = await GetUserIfExist(userId, trackChanges);
            var apart = await GetApartIfExist(apartId, trackChanges);

            var occup = await _repository.Occupancy
                .GetOccupancyByIdAsync(id, trackChanges);
            _repository.Occupancy.DeleteOccupancy(occup);

            await _repository.SaveAsync();
        }

        private async Task<ApartmentDto> GetApartIfExist(Guid apartId, bool trackChanges)
        {
            var apart = await _repository.Apartment
                .GetApartmentByIdAsync(apartId, trackChanges);
            if (apart is null)
                throw new ApartmentNotFoundException(apartId);

            return _mapper.Map<ApartmentDto>(apart);
        }

        private async Task<User> GetUserIfExist(string userId, bool trackChanges)
        {
            var user = await _repository.User
                .GetUserByIdAsync(userId.ToString(), trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);

            return user;
        }
    }
}
