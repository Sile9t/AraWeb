using Service.Contracts.Services;

namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IAuthenticationService AuthenticationService { get; }
        IApartmentService ApartmentService { get; }
        IReservationDateService ReservationDateService { get; }
        IOccupancyService OccupancyService { get; }
    }
}
