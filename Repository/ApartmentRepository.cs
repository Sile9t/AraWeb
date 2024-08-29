using Contracts;
using Entities.Models;

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

        public IEnumerable<Apartment> GetApartmentsByIds(IEnumerable<Guid> ids,
            bool trackChanges) =>
            FindByCondition(a => ids.Contains(a.Id), trackChanges)
            .ToList();

        public Apartment GetApartmentById(Guid id, bool trackChanges) =>
            FindByCondition(a => a.Id.Equals(id), trackChanges)
            .SingleOrDefault()!;

        public void CreateApartment(Apartment apartment) =>
            Create(apartment);
    }
}
