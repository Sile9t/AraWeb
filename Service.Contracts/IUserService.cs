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
        Task<IEnumerable<UserDto>> GetUsersByIdsAsync(IEnumerable<Guid> ids,
            bool trackChanges);
        Task<UserDto> GetUserByIdAsync(Guid id, bool trackChanges);
        Task<UserDto> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges);
        Task DeleteUserAsync(Guid id, bool trackChanges);
        Task UpdateUserAsync(Guid id, UserForUpdateDto userForUpdate, bool trackChanges);
    }
}
