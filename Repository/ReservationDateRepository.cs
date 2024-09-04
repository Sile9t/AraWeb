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

        public async Task<IEnumerable<ReservationDate>> GetAllAsync(bool trackChanges)
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

        void Create(ReservationDate reservationDate) =>
            Create(reservationDate);

        void Delete(ReservationDate reservationDate) =>
            Delete(reservationDate);
    }
}
