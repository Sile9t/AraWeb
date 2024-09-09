using ActionFilter;
using AraWeb.ActionFilters;
using AraWeb.Presentation.ModelBinder;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.RequestFeatures;
using System.Text.Json;

namespace AraWeb.Presentation
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public UsersController(IServiceManager service) =>
            _service = service;

        [HttpGet(Name = "GetAllUsers")]
        [ServiceFilter(typeof(ValidateMediaTypeAttribute))]
        public async Task<IActionResult> GetAllUsers([FromQuery]UserParameters userParameters)
        {
            var users = await _service.UserService.GetAllUsersAsync(userParameters, 
                trackChanges: false);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(users.metaData));

            return Ok(users.users);
        }

        [HttpGet("collection")]
        public async Task<IActionResult> GetUserCollection([ModelBinder(BinderType 
            = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            var users = await _service.UserService
                .GetUsersByIdsAsync(ids, trackChanges: false);

            return Ok(users);
        }

        [HttpGet("{id:guid}", Name = "GetUserById")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _service.UserService
                .GetUserByIdAsync(id, trackChanges: false);

            return Ok(user);
        }
    }
}
