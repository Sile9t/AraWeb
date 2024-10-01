using Contracts.Repositories;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IApartmentRepository> _apartmentRepository;
        private readonly Lazy<IReservationDateRepository> _reservationDateRepository;
        private readonly Lazy<IOccupancyRepository> _occupancyRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _userRepository = new Lazy<IUserRepository>(() =>
                new UserRepository(repositoryContext));
            _apartmentRepository = new Lazy<IApartmentRepository>(() =>
                new ApartmentRepository(repositoryContext));
            _reservationDateRepository = new Lazy<IReservationDateRepository>(() =>
                new ReservationDateRepository(repositoryContext));
            _occupancyRepository = new Lazy<IOccupancyRepository>(() =>
                new OccupancyRepository(repositoryContext));
        }

        public IUserRepository User => _userRepository.Value;
        public IApartmentRepository Apartment => _apartmentRepository.Value;
        public IReservationDateRepository ReservationDate => _reservationDateRepository.Value;
        public IOccupancyRepository Occupancy => _occupancyRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
