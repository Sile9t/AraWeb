using AutoMapper;
using Contracts;
using Contracts.Repositories;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts.Services;
using Shared.Dtos;

namespace Service.Services
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

        public async Task<IEnumerable<OccupancyDto>> GetOccupanciesForUserAsync(Guid userId,
            bool trackChanges)
        {
            var occups = await _repository.Occupancy
                .GetOccupanciesForUserAsync(userId, trackChanges);

            var occupDtos = _mapper.Map<IEnumerable<OccupancyDto>>(occups);

            return occupDtos;
        }

        public async Task<OccupancyDto> GetOccupancyByIdAsync(Guid occupId, bool trackChanges)
        {
            var occup = await _repository.Occupancy
                .GetOccupancyByIdAsync(occupId, trackChanges);
            if (occup is null)
                throw new OccupancyNotFoundException(occupId);

            var occupDto = _mapper.Map<OccupancyDto>(occup);

            return occupDto;
        }

        public async Task<IEnumerable<OccupancyDto>> GetOccupanciesByIdsAsync(IEnumerable<Guid> occupIds,
            bool trackChanges)
        {
            if (occupIds is null)
                throw new IdParametersBadRequestException();

            var occups = await _repository.Occupancy
                .GetOccupanciesByIdsAsync(occupIds, trackChanges);
            if (occupIds.Count() != occups.Count())
                throw new CollectionByIdsBadRequestException();

            var occupDtos = _mapper.Map<IEnumerable<OccupancyDto>>(occups);

            return occupDtos;
        }

        public async Task<OccupancyDto> CreateOccupancyForUserAndApartmentAsync(Guid userId,
            Guid apartId, OccupancyForCreationDto occupancyDto, bool userTrackChanges,
            bool apartTrackChanges, bool occupTrackChanges)
        {
            var user = GetUserIfExist(userId, userTrackChanges);
            var apart = GetApartIfExist(apartId, apartTrackChanges);

            var occup = _mapper.Map<Occupancy>(occupancyDto);

            _repository.Occupancy.CreateOccupancy(userId, apartId, occup);
            await _repository.SaveAsync();

            var occupDto = _mapper.Map<OccupancyDto>(occup);
            return occupDto;
        }

        public async Task<IEnumerable<OccupancyDto>> CreateOccupancyCollectionForUserAndApartmentAsync(
            Guid userId, Guid apartId, IEnumerable<OccupancyForCreationDto> occupCollection,
            bool userTrackChanges, bool apartTrackChanges, bool occupTrackChanges)
        {
            var user = GetUserIfExist(userId, userTrackChanges);
            var apart = GetApartIfExist(apartId, apartTrackChanges);

            var occups = _mapper.Map<IEnumerable<Occupancy>>(occupCollection);
            foreach (var occup in occups)
            {
                _repository.Occupancy.CreateOccupancy(userId, apartId, occup);
                await _repository.SaveAsync();
            }

            var occupDtos = _mapper.Map<IEnumerable<OccupancyDto>>(occups);

            return occupDtos;
        }

        public async Task DeleteOccupancyAsync(Guid id, bool trackChanges)
        {
            var occup = await _repository.Occupancy
                .GetOccupancyByIdAsync(id, trackChanges);
            if (occup is null) throw new OccupancyNotFoundException(id);

            _repository.Occupancy.DeleteOccupancy(occup);

            await _repository.SaveAsync();
        }

        public async Task DeleteOccupancyCollectionAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var occups = await _repository.Occupancy
                .GetOccupanciesByIdsAsync(ids, trackChanges);

            if (occups.Count() != ids.Count())
                throw new CollectionByIdsBadRequestException();

            foreach (var occup in occups)
                _repository.Occupancy.DeleteOccupancy(occup);

            await _repository.SaveAsync();
        }

        public async Task UpdateOccupancyAsync(Guid occupId, OccupancyForUpdateDto occupancyDto,
            bool trackChanges)
        {
            var occup = await _repository.Occupancy
                .GetOccupancyByIdAsync(occupId, trackChanges);
            _mapper.Map(occupancyDto, occup);

            await _repository.SaveAsync();
        }

        public async Task<(OccupancyForUpdateDto occupToPatch, Occupancy occup)>
            GetOccupancyForPatchAsync(Guid occupId, bool trackChanges)
        {
            var occup = await _repository.Occupancy
                .GetOccupancyByIdAsync(occupId, trackChanges);
            if (occup is null)
                throw new OccupancyNotFoundException(occupId);

            var occupToPatch = _mapper.Map<OccupancyForUpdateDto>(occup);

            return (occupToPatch, occup);
        }

        public async Task SaveChangesForPatchAsync(OccupancyForUpdateDto occupToPatch, Occupancy occup)
        {
            _mapper.Map(occupToPatch, occup);
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

        private async Task<User> GetUserIfExist(Guid userId, bool trackChanges)
        {
            var user = await _repository.User
                .GetUserByIdAsync(userId, trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);

            return user;
        }
    }
}
