using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.Dtos;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IApartmentService> _apartmentService;
        private readonly Lazy<IReservationDateService> _reservationDateService;
        private readonly Lazy<IOccupancyService> _occupancyService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger,
            IMapper mapper, IDataShaper<ApartmentDto> dataShaper)
        {
            _userService = new Lazy<IUserService>(() => 
                new UserService(repositoryManager, logger));
            _apartmentService = new Lazy<IApartmentService>(() => 
                new ApartmentService(repositoryManager, logger, mapper, dataShaper));
            _reservationDateService = new Lazy<IReservationDateService>(() => 
                new ReservationDateService(repositoryManager, logger));
            _occupancyService = new Lazy<IOccupancyService>(() => 
                new OccupancyService(repositoryManager, logger));
        }

        public IUserService UserService => _userService.Value;
        public IApartmentService ApartmentService => _apartmentService.Value;
        public IReservationDateService ReservationDateService => _reservationDateService.Value;
        public IOccupancyService OccupancyService => _occupancyService.Value;
    }
}
