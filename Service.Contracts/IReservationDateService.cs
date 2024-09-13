using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IReservationDateService
    {
        Task<IEnumerable<ReservationDateDto>> GetAllDatesAsync(bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentAsync(Guid apartId, 
            bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForUserAsync(string userId, bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentsAsync(IEnumerable<Guid> apartIds, 
            bool trackChanges);
        Task<ReservationDateDto> GetDate(DateTime date, Guid apartId, 
            bool apartTrackChanges, bool dateTrackChanges);
        Task CreateDateAsync(ReservationDateForCreationDto reservationDate);
        Task CreateDateCollectionAsync(IEnumerable<ReservationDateForCreationDto> datesCollection);
        Task UpdateDateAsync(ReservationDateForUpdateDto reservationDate, bool apartTrackChanges,
            bool dateTrackChanges);
        Task DeleteDateAsync(DateTime date, Guid apartId, bool apartTrackChanges,
            bool dateTrackChanges);
    }
}
