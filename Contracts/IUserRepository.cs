using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<PagedList<User>> GetAllUsersAsync(RequestParameters requestParameters,
            bool trackChanges);
        Task<IEnumerable<User>> GetUsersByIdsAsync(IEnumerable<string> ids,
            bool trackChanges);
        Task<User> GetUserByIdAsync(string id, bool trackChanges);
        Task<User> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges);
    }
}
