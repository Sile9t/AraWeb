using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Presentation
{
    [Route("[controller]")]
    [ApiController]
    public class OccupanciesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public OccupanciesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetAllOccupancies")]
        public async Task<IActionResult> GetAllOccupancies()
        {
            var occups = await _service.OccupancyService
                .GetAllOccupanciesAsync(trackChanges: false);

            return Ok(occups);
        }

        [HttpGet("profile/{id:guid}", Name = "GetOccupanciesForUser")]
        public async Task<IActionResult> GetOccupaciesForUser(Guid userId)
        {
            var occups = await _service.OccupancyService
                .GetOccupanciesForUserAsync(userId.ToString(), trackChanges: false);

            return Ok(occups);
        }

        [HttpPost("id:guid", Name = "CreateOccupancyForApartment")]
        public async Task<IActionResult> CreateOccupancyForApartment(Guid apartId, 
            [FromQuery]OccupancyForCreationDto occupancyDto)
        {
            var user = _service.AuthenticationService.GetUserProfile();
            var occup = await _service.OccupancyService
                .CreateOccupancyForApartmentAsync(user.Id,apartId, occupancyDto, 
                    userTrackChanges: true, apartTrackChanges: true, occupTrackChanges: false);

            return Ok(occup);
        }
    }
}
