using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ReservationDateRepository : RepositoryBase<ReservationDate>, IReservationDateRepository
    {
        public ReservationDateRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public async Task<IEnumerable<ReservationDate>> GetAllDatesAsync(bool trackChanges)
        {
            var dates = await FindAll(trackChanges)
                .ToListAsync();

            return dates;
        }

        public async Task<IEnumerable<ReservationDate>> GetDatesForApartmentAsync(Guid apartId, bool trackChanges)
        {
            var dates = await FindByCondition(d => d.ApartmentId.Equals(apartId), trackChanges)
                .ToListAsync();

            return dates;
        }

        public async Task<IEnumerable<ReservationDate>> GetDatesForUserAsync(Guid userId,
            bool trackChanges) =>
            await FindByCondition(d => d.Occupancy!.ReservedById!.Equals(userId), trackChanges)
                .ToListAsync();

        public async Task<ReservationDate?> GetDate(DateTime date, Guid apartId, bool trackChanges) =>
            await FindByCondition(d => d.Date.Date.Equals(date) 
                && d.ApartmentId.Equals(apartId), trackChanges)
                .FirstOrDefaultAsync();

        public void CreateDate(ReservationDate reservationDate) =>
            Create(reservationDate);

        public void DeleteDate(ReservationDate reservationDate) =>
            Delete(reservationDate);
    }
}
