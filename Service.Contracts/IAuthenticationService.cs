using Microsoft.AspNetCore.Identity;
using Shared.Dtos;

namespace Service.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<IdentityResult> UpdateUser(UserForUpdateDto userForUpdate);
        Task<TokenDto> CreateToken(bool populateExp);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}
