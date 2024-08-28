using Contracts;
using Entities.Models;
using Service.Contracts;
using Shared.Dtos;

namespace Service
{
    internal class ApartmentService : IApartmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ApartmentService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<Apartment> GetAllApartments(bool trackChanges)
        {
            var apartments = _repository.Apartment.GetAllApartments(trackChanges);
            if (apartments is null)
                throw new Exception();

            return apartments;
        }
    }
}
