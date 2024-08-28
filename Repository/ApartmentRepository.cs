using Contracts;
using Entities.Models;
using Shared.Dtos;

namespace Repository
{
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<ApartmentDto> GetAllApartments(bool trackChanges)
        {
            FindAll(trackChanges)
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}
