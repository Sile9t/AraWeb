using Contracts;
using Entities;

namespace Repository
{
    public class ReservationDateRepository : RepositoryBase<ReservationDate>, IReservationDateRepository
    {
        public ReservationDateRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
             
        }
    }
}
