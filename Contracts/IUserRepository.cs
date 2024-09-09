using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUsersAsync(UserParameters userParameters,
            bool trackChanges);
        Task<IEnumerable<User>> GetUsersByIdsAsync(IEnumerable<string> ids,
            bool trackChanges);
        Task<User> GetUserByIdAsync(string id, bool trackChanges);
        Task<User> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        void DeleteUser(User user);
    }
}
