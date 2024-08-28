using Contracts;
using Service.Contracts;

namespace Service
{
    internal class OccupancyService : IOccupancyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public OccupancyService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
