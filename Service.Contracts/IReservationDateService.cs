using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IReservationDateService
    {
        Task<IEnumerable<ReservationDateDto>> GetAllDatesAsync(bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentAsync(Guid apartId, 
            bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForUserAsync(Guid userId, bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentsAsync(IEnumerable<Guid> apartIds, 
            bool trackChanges);
        Task<ReservationDateDto> GetDateForApartmentAsync(DateTime date, Guid apartId, 
            bool apartTrackChanges, bool dateTrackChanges);
        Task CreateDateForApartmentAsync(Guid apartId, 
            ReservationDateForCreationDto reservationDate, bool trackChanges);
        Task CreateDateCollectionForApartmentAsync(Guid apartId,
            IEnumerable<ReservationDateForCreationDto> datesCollection, bool trackChanges);
        Task GenerateEmptyDatesForApartmentAsync(Guid apartId, bool trackChanges);
        Task UpdateDateAsync(ReservationDateForUpdateDto reservationDate, bool apartTrackChanges,
            bool dateTrackChanges);
        Task DeleteDateAsync(DateTime date, Guid apartId, bool apartTrackChanges,
            bool dateTrackChanges);
    }
}
