using Entities.LinkModels;
using Entities.Models;
using Shared.Dtos;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IUserService
    {
        Task<MetaData> GetAllUsersAsync(RequestParameters requestParameters,
            bool trackChanges);
        Task<IEnumerable<UserDto>> GetUsersByIdsAsync(IEnumerable<string> ids,
            bool trackChanges);
        Task<UserDto> GetUserByIdAsync(string id, bool trackChanges);
        Task<UserDto> GetUserByPhoneNumberAsync(string phoneNumber, bool trackChanges);
    }
}
