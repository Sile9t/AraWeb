using Contracts;
using Entities.Models;

namespace Repository
{
    public class OccupancyRepository : RepositoryBase<Occupancy>, IOccupancyRepository
    {
        public OccupancyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
