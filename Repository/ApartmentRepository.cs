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

        public IEnumerable<Apartment> GetAllApartments(bool trackChanges)
        {
            return FindAll(trackChanges)
                .OrderBy(a => a.Name)
                .ToList();
        }

        public Apartment GetApartmentById(Guid id, bool trackChanges) =>
            FindByCondition(a => a.Id.Equals(id), trackChanges)
            .SingleOrDefault()!;
    }
}
