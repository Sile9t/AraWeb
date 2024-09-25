using Contracts;
using Entities.Models;
using Entities.Exceptions;
using Service.Contracts;
using Shared.Dtos;
using AutoMapper;

namespace Service
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

            List<ReservationDateDto> dates = new ();
            foreach (var apartId in apartIds)
            {
                var apartDates = await _repository.ReservationDate
                    .GetDatesForApartmentAsync(apartId, trackChanges);
                dates.AddRange(_mapper.Map<IEnumerable<ReservationDateDto>>(apartDates));
            }

            return dates;
        }

        public async Task<ReservationDateDto> GetDateForApartmentAsync(DateTime date, Guid apartId, 
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

        public async Task CheckAllApartmentsForDatesAndGenerateThemIfNotEnough(bool trackChanges, 
            DateTime firstDate, DateTime secondDate)
        {
            var aparts = await _repository.Apartment.GetAllApartmentsAsync(trackChanges);
            var dateRange = GenerateDates(firstDate, secondDate).ToList();

            var tasks = from a in aparts select Task.Run(async () =>
                await GenerateEmptyDatesForApartmentAsync(a.Id, trackChanges, dateRange));

            CancellationTokenSource tokenSource = new ();
            var token = tokenSource.Token;
            await Parallel.ForEachAsync(aparts,
                async (apart, token) => await GenerateEmptyDatesForApartmentAsync(apart.Id, false, dateRange));
            await Task.Delay(1_000);
            tokenSource.Cancel();

            foreach (var apart in aparts)
            {
                await GenerateEmptyDatesForApartmentAsync(apart.Id, trackChanges, dateRange);
            }
        }

        public async Task GenerateEmptyDatesForApartmentAsync(Guid apartId, bool trackChanges, 
            IEnumerable<DateTime> dateRange)
        {
            var existingDates = 
                await _repository.ReservationDate
                .GetDatesForApartmentAsync(apartId, trackChanges);
            var dates = dateRange.Except(existingDates.Select(d => d.Date))
                .Select(d => new ReservationDateForCreationDto { Date = d, ApartmentId = apartId });

            if (dates is null) return;

            await CreateDateCollectionForApartmentAsync(apartId, dates, trackChanges);
        }

        public async Task GenerateEmptyDatesForNewApartmentAsync(Guid apartId, bool trackChages,
            DateTime firstDate, DateTime secondDate)
        {
            var dates = GenerateDates(firstDate, secondDate);
            var emptyDates = dates
                .Select(d => new ReservationDateForCreationDto { Date = d, ApartmentId = apartId });

            await CreateDateCollectionForApartmentAsync(apartId, emptyDates, trackChages);
        }

        private IEnumerable<DateTime> GenerateDates(DateTime start, DateTime end)
        {
            var startDate = start.AddDays(1 - start.Day).Date;
            var endDate = end.Date.AddMonths(1).AddDays(1 - end.Date.Day).Date;
            var dateSub = endDate.Subtract(startDate);
            var days = dateSub.TotalDays - endDate.Day + 1;
            var range = Enumerable.Range(0, (int)days)
                .Select(x => startDate.AddDays(1.0 * x).Date);

            return range;
        }


        public async Task UpdateDateAsync(ReservationDateForUpdateDto dateDto,
            bool apartTrackChanges, bool dateTrackChanges)
        {
            var apartId = dateDto.ApartmentId;
            var apart = await _repository.Apartment.GetApartmentByIdAsync(apartId, 
                apartTrackChanges);
            if (apart is null)
                throw new ApartmentNotFoundException(apartId);

            var dateEntity = await _repository.ReservationDate
                .GetDateForApartmentAsync(dateDto.Date, apartId, dateTrackChanges);
            _mapper.Map(dateDto, dateEntity);

            await _repository.SaveAsync();
        }

        public async Task DeleteDateAsync(DateTime date, Guid apartId, bool apartTrackChages,
            bool dateTrackChanges)
        {
            await GetApartIfExistAsync(apartId, apartTrackChages);

            var dateEntity = await _repository.ReservationDate
                .GetDateForApartmentAsync(date, apartId, dateTrackChanges);
            if (dateEntity is null)
                throw new DateNotFoundException(date, apartId);

            _repository.ReservationDate.DeleteDate(dateEntity);

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
