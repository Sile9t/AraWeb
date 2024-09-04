using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUsersAsync(
            bool trackChanges);
        Task<IEnumerable<User>> GetUsersByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges);
        Task<User> GetUserByIdAsync(Guid id, bool trackChanges);
        Task<User> GetUsersByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
