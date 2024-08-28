namespace Service.Contracts
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
        IApartmentService ApartmentService { get; }
        IReservationDateService ReservationDateService { get; }
        IOccupancyService OccupancyService { get; }
    }
}
