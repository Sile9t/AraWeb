using Entities.Models;

namespace Contracts
{
    public interface IReservationDateRepository
    {
        Task<IEnumerable<ReservationDate>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<ReservationDate>> GetDatesForApartmentAsync(Guid apartId, bool trackChanges);
        void Create(ReservationDate reservationDate);
        void Delete(ReservationDate resrevationDate);
    }
}
