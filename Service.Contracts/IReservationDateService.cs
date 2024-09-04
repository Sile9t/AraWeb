using Entities.Models;

namespace Service.Contracts
{
    public interface IReservationDateService
    {
        Task<IEnumerable<ReservationDate>> GetAllDatesAsync(bool trackChanges);
        Task<IEnumerable<ReservationDate>> GetDatesForApartmentAsync(Guid apartId, bool trackChanges);
        Task<ReservationDate> CreateDateAsync(ReservationDate reservationDate);
        Task<IEnumerable<ReservationDate>> CreateDateCollectionAsync(IEnumerable<ReservationDate> datesCollection);
        Task UpdateAsync(ReservationDate reservationDate);
        Task DeleteAsync(ReservationDate reservationDate);
    }
}
