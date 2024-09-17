using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters,
            bool trackChanges);
        Task<IEnumerable<User>> GetUsersByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges);
        Task<User> GetUserByIdAsync(Guid id, bool trackChanges);
        Task<User> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        void DeleteUser(User user);
    }
}
