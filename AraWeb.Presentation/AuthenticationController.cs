using AraWeb.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Presentation
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AuthenticationController(IServiceManager service) 
            => _service = service;

        [HttpPost("register")]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> RegisterUser([FromBody] 
            UserForRegistrationDto userForRegistration)
        {
            var result = await _service.AuthenticationService.RegisterUser(userForRegistration);
            if(!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.TryAddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }

        [HttpPost("login")]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _service.AuthenticationService.ValidateUser(user))
                return Unauthorized();

            var tokenDto = await _service.AuthenticationService
                .CreateToken(populateExp: true);

            return Ok(tokenDto);
        }

        [HttpPut]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> UpdateUser([FromBody] UserForUpdateDto user)
        {
            var result = await _service.AuthenticationService.UpdateUser(user);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.TryAddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }

            return StatusCode(201);
        }
    }
}
