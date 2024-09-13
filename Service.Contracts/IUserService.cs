using Entities.LinkModels;
using Entities.Models;
using Shared.Dtos;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IUserService
    {
        Task<(IEnumerable<UserDto> users, MetaData metaData)> GetAllUsersAsync(UserParameters userParameters,
            bool trackChanges);
        Task<IEnumerable<UserDto>> GetUsersByIdsAsync(IEnumerable<string> ids,
            bool trackChanges);
        Task<UserDto> GetUserByIdAsync(string id, bool trackChanges);
        Task<UserDto> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        Task DeleteUserAsync(string id, bool trackChanges);
        Task UpdateUserAsync(string id, UserForUpdateDto userForUpdate, bool trackChanges);
    }
}
