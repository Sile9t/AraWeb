using Contracts;
using Service.Contracts;

namespace Service
{
    internal class ReservationDateService : IReservationDateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public ReservationDateService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
