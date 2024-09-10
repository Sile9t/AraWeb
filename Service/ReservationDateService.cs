using Contracts;
using Entities.Models;
using Entities.Exceptions;
using Service.Contracts;

namespace Service
{
    internal class ReservationDateService : IReservationDateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ReservationDateService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<ReservationDate>> GetAllDatesAsync(bool trackChanges)
        {
            var dates = await _repository.ReservationDate.GetAllDatesAsync(trackChanges);

            return dates;
        }

        public async Task<IEnumerable<ReservationDate>> GetDatesForApartmentAsync(Guid apartId, bool trackChanges)
        {
            var apart = await _repository.Apartment.GetApartmentByIdAsync(apartId, trackChanges);
            if (apart is null)
                throw new ApartmentNotFoundException(apartId);

            var dates = await _repository.ReservationDate.GetDatesForApartmentAsync(apartId, trackChanges);

            return dates;
        }

        public async Task<IEnumerable<ReservationDate>> GetDatesForUserAsync(Guid userId,
            bool trackChanges)
        {
            var dates = await _repository.ReservationDate.GetDatesForUserAsync(userId.ToString(),
                trackChanges);

            return dates;
        }

        public async Task<ReservationDate> GetDate(DateTime date, Guid apartId, 
            bool apartTrackChanges, bool dateTrackChanges)
        {
            var apart = GetApartIfExist(apartId, apartTrackChanges);

            var reservationDate = await _repository.ReservationDate
                .GetDate(date, apartId, dateTrackChanges);
            if (reservationDate is null)
                reservationDate = _repository.ReservationDate
                    .CreateDate(date, apartId);

            return reservationDate;
        }

        public async Task CreateDateAsync(ReservationDate reservationDate)
        {
            _repository.ReservationDate.CreateDate(reservationDate);

            await _repository.SaveAsync();
        }

        public async Task CreateDateCollectionAsync(
            IEnumerable<ReservationDate> datesCollection)
        {
            foreach (var date in datesCollection)
                _repository.ReservationDate.CreateDate(date);

            await _repository.SaveAsync();
        }

        public async Task UpdateAsync(DateTime date, Guid apartId, ReservationDate reservationDate,
            bool apartTrackChanges, bool dateTrackChanges)
        {
            var apart = await _repository.Apartment.GetApartmentByIdAsync(apartId, 
                apartTrackChanges);
            if (apart is null)
                throw new ApartmentNotFoundException(apartId);

            var reservDate = await _repository.ReservationDate.GetDate(date, apartId, 
                dateTrackChanges);
            if (reservDate is null)
            {
                var newDate = new ReservationDate(date, apartId);
                _repository.ReservationDate.CreateDate(newDate);
            }

            await _repository.SaveAsync();
        }

        public async Task DeleteAsync(ReservationDate reservationDate)
        {
            _repository.ReservationDate.DeleteDate(reservationDate);

            await _repository.SaveAsync();
        }

        private async Task<Apartment> GetApartIfExist(Guid apartId, bool trackChanges)
        {
            var apart = await _repository.Apartment
                .GetApartmentByIdAsync(apartId, trackChanges);
            if (apart is null)
                throw new ApartmentNotFoundException(apartId);

            return apart;
        }
    }
}
