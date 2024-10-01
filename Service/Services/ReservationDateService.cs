using Contracts;
using Entities.Models;
using Entities.Exceptions;
using Shared.Dtos;
using AutoMapper;
using Contracts.Repositories;
using Service.Contracts.Services;

namespace Service.Services
{
    internal class ReservationDateService : IReservationDateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReservationDateService(IRepositoryManager repository, ILoggerManager logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReservationDateDto>> GetAllDatesAsync(bool trackChanges)
        {
            var dates = await _repository.ReservationDate.GetAllDatesAsync(trackChanges);

            var datesDto = _mapper.Map<IEnumerable<ReservationDateDto>>(dates);

            return datesDto;
        }

        public async Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentAsync(Guid apartId,
            bool trackChanges)
        {
            var apart = GetApartIfExistAsync(apartId, trackChanges);

            var dates = await _repository.ReservationDate.GetDatesForApartmentAsync(apartId,
                trackChanges);
            var datesDto = _mapper.Map<IEnumerable<ReservationDateDto>>(dates);

            return datesDto;
        }

        public async Task<IEnumerable<ReservationDateDto>> GetDatesForUserAsync(Guid userId,
            bool trackChanges)
        {
            var user = _repository.User.GetUserByIdAsync(userId, trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);

            var dates = await _repository.ReservationDate.GetDatesForUserAsync(userId,
                trackChanges);

            var datesDto = _mapper.Map<IEnumerable<ReservationDateDto>>(dates);

            return datesDto;
        }

        public async Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentsAsync(IEnumerable<Guid> apartIds,
            bool trackChanges)
        {
            if (apartIds is null)
                throw new IdParametersBadRequestException();

            List<ReservationDateDto> dates = new();
            foreach (var apartId in apartIds)
            {
                var apartDates = await _repository.ReservationDate
                    .GetDatesForApartmentAsync(apartId, trackChanges);
                dates.AddRange(_mapper.Map<IEnumerable<ReservationDateDto>>(apartDates));
            }

            return dates;
        }

        public async Task<ReservationDateDto> GetDateForApartmentAsync(Guid apartId, DateTime date,
            bool apartTrackChanges, bool dateTrackChanges)
        {
            var apart = GetApartIfExistAsync(apartId, apartTrackChanges);

            var reservationDate = await _repository.ReservationDate
                .GetDateForApartmentAsync(date, apartId, dateTrackChanges);
            if (reservationDate is null)
                throw new DateNotFoundException(date, apartId);

            var dateDto = _mapper.Map<ReservationDateDto>(reservationDate);

            return dateDto;
        }

        public async Task CreateDateForApartmentAsync(Guid apartId,
            ReservationDateForCreationDto dateDto, bool trackChanges)
        {
            var apart = GetApartIfExistAsync(apartId, trackChanges);

            var date = _mapper.Map<ReservationDate>(dateDto);

            _repository.ReservationDate.CreateDate(date);

            await _repository.SaveAsync();
        }

        public async Task CreateDateCollectionForApartmentAsync(Guid apartId,
            IEnumerable<ReservationDateForCreationDto> dateCollection, bool trackChanges)
        {
            var apart = GetApartIfExistAsync(apartId, trackChanges);

            var dateDtoCollection = _mapper.Map<IEnumerable<ReservationDate>>(dateCollection);

            foreach (var date in dateDtoCollection)
                _repository.ReservationDate.CreateDate(date);

            await _repository.SaveAsync();
        }

        public async Task UpdateDateForApartmentAsync(ReservationDateForUpdateDto dateDto,
            bool apartTrackChanges, bool dateTrackChanges)
        {
            var apartId = dateDto.ApartmentId;
            await GetApartIfExistAsync(apartId, apartTrackChanges);

            var dateEntity = await _repository.ReservationDate
                .GetDateForApartmentAsync(dateDto.Date, apartId, dateTrackChanges);
            _mapper.Map(dateDto, dateEntity);

            await _repository.SaveAsync();
        }

        public async Task UpdateDateCollectionForApartmentAsync(
            IEnumerable<ReservationDateForUpdateDto> dateDtos, bool trackChanges)
        {
            var apartId = dateDtos.FirstOrDefault()!.ApartmentId;
            await GetApartIfExistAsync(apartId, trackChanges);

            var dateEntities = await _repository.ReservationDate
                .GetDatesForApartmentAsync(apartId, trackChanges);
            _mapper.Map(dateDtos, dateEntities);

            await _repository.SaveAsync();
        }

        public async Task DeleteDateForApartmentAsync(Guid apartId, DateTime date,
            bool trackChanges)
        {
            await GetApartIfExistAsync(apartId, trackChanges);

            var dateEntity = await _repository.ReservationDate
                .GetDateForApartmentAsync(date, apartId, trackChanges);
            if (dateEntity is null)
                throw new DateNotFoundException(date, apartId);

            _repository.ReservationDate.DeleteDate(dateEntity);

            await _repository.SaveAsync();
        }

        public async Task DeleteDateCollectionForApartmentAsync(Guid apartId,
            IEnumerable<DateTime> dateRange, bool trackChanges)
        {
            await GetApartIfExistAsync(apartId, trackChanges);

            var dateEntities = await _repository.ReservationDate
                .GetDatesForApartmentAsync(apartId, trackChanges);
            dateEntities = dateEntities.Where(d => dateRange.Contains(d.Date));

            foreach (var date in dateEntities)
                _repository.ReservationDate.DeleteDate(date);

            await _repository.SaveAsync();
        }

        public async Task<(ReservationDateForUpdateDto dateToPatch, ReservationDate dateEntity)>
            GetDateForApartmentToPatchAsync(Guid apartId, DateTime date, bool trackChanges)
        {
            await GetApartIfExistAsync(apartId, trackChanges);

            var dateEntity = await _repository.ReservationDate
                .GetDateForApartmentAsync(date, apartId, trackChanges);
            if (dateEntity is null)
                throw new DateNotFoundException(date, apartId);

            var dateForPatch = _mapper.Map<ReservationDateForUpdateDto>(dateEntity);

            return (dateForPatch, dateEntity);
        }

        public async Task<(IEnumerable<ReservationDateForUpdateDto>? datesToPatch,
            IEnumerable<ReservationDate>? dateEntities)>
            GetDatesForApartmentToPatchAsync(Guid apartId, IEnumerable<DateTime> dateRange, bool trackChanges)
        {
            await GetApartIfExistAsync(apartId, trackChanges);

            var dateEntities = await _repository.ReservationDate
                .GetDatesForApartmentAsync(apartId, trackChanges);
            dateEntities = dateEntities.Where(d => dateRange.Contains(d.Date));

            var dateForPatch = _mapper.Map<IEnumerable<ReservationDateForUpdateDto>?>(dateEntities);

            return (dateForPatch, dateEntities);
        }

        public async Task SaveChangesForPatchAsync(ReservationDateForUpdateDto dateToPatch,
            ReservationDate dateEntity)
        {
            _mapper.Map(dateToPatch, dateEntity);
            await _repository.SaveAsync();
        }

        public async Task SaveChangesForPatchAsync(
            IEnumerable<ReservationDateForUpdateDto> datesToPatch,
            IEnumerable<ReservationDate> dateEntiites)
        {
            _mapper.Map(datesToPatch, dateEntiites);
            await _repository.SaveAsync();
        }

        private async Task<Apartment> GetApartIfExistAsync(Guid apartId, bool trackChanges)
        {
            var apart = await _repository.Apartment
                .GetApartmentByIdAsync(apartId, trackChanges);
            if (apart is null)
                throw new ApartmentNotFoundException(apartId);

            return apart;
        }
    }
}
