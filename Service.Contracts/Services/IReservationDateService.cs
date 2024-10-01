using Entities.Models;
using Shared.Dtos;

namespace Service.Contracts.Services
{
    public interface IReservationDateService
    {
        Task<IEnumerable<ReservationDateDto>> GetAllDatesAsync(bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentAsync(Guid apartId,
            bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForUserAsync(Guid userId, bool trackChanges);
        Task<IEnumerable<ReservationDateDto>> GetDatesForApartmentsAsync(
            IEnumerable<Guid> apartIds, bool trackChanges);
        Task<ReservationDateDto> GetDateForApartmentAsync(Guid apartId, DateTime date,
            bool apartTrackChanges, bool dateTrackChanges);
        Task CreateDateForApartmentAsync(Guid apartId,
            ReservationDateForCreationDto reservationDate, bool trackChanges);
        Task CreateDateCollectionForApartmentAsync(Guid apartId,
            IEnumerable<ReservationDateForCreationDto> datesCollection, bool trackChanges);
        Task UpdateDateForApartmentAsync(ReservationDateForUpdateDto reservationDate,
            bool apartTrackChanges, bool dateTrackChanges);
        Task UpdateDateCollectionForApartmentAsync(
            IEnumerable<ReservationDateForUpdateDto> datesForUpdate, bool trackChanges);
        Task DeleteDateForApartmentAsync(Guid apartId, DateTime date, bool trackChanges);
        Task DeleteDateCollectionForApartmentAsync(Guid apartId, IEnumerable<DateTime> dateRange,
            bool trackChanges);
        Task<(ReservationDateForUpdateDto dateToPatch, ReservationDate dateEntity)>
            GetDateForApartmentToPatchAsync(Guid apartId, DateTime date, bool trackChanges);
        Task<(IEnumerable<ReservationDateForUpdateDto>? datesToPatch,
            IEnumerable<ReservationDate>? dateEntities)>
            GetDatesForApartmentToPatchAsync(Guid apartId, IEnumerable<DateTime> dateRange,
            bool trackChanges);
        Task SaveChangesForPatchAsync(ReservationDateForUpdateDto dateToPatch,
            ReservationDate dateEntity);
        public Task SaveChangesForPatchAsync(
            IEnumerable<ReservationDateForUpdateDto> datesToPatch,
            IEnumerable<ReservationDate> dateEntiites);
    }
}
