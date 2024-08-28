using Contracts;
using Service.Contracts;

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
    }
}
