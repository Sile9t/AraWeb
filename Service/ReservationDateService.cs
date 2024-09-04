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
            var dates = await _repository.ReservationDate.GetAllAsync(trackChanges);

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

        public Task<ReservationDate> CreateDateAsync(ReservationDate reservationDate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReservationDate>> CreateDateCollectionAsync(IEnumerable<ReservationDate> datesCollection)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ReservationDate reservationDate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(ReservationDate reservationDate)
        {
            throw new NotImplementedException();
        }
    }
}
