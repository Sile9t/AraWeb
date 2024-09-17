using Entities.Models;

namespace Contracts
{
    public interface IReservationDateRepository
    {
        Task<IEnumerable<ReservationDate>> GetAllDatesAsync(bool trackChanges);
        Task<IEnumerable<ReservationDate>> GetDatesForApartmentAsync(Guid apartId, 
            bool trackChanges);
        Task<IEnumerable<ReservationDate>> GetDatesForUserAsync(Guid userId, 
            bool trackChanges);
        Task<ReservationDate?> GetDateForApartmentAsync(DateTime date, Guid apartId, bool trackChanges);
        void CreateDate(ReservationDate reservationDate);
        void DeleteDate(ReservationDate resrevationDate);
    }
}
