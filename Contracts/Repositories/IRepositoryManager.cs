namespace Contracts.Repositories
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        IApartmentRepository Apartment { get; }
        IReservationDateRepository ReservationDate { get; }
        IOccupancyRepository Occupancy { get; }
        Task SaveAsync();
    }
}
