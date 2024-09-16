using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;
using Shared.RequestFeatures;
using System.Security.Claims;

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
        [Authorize]
        public async Task<IActionResult> CreateOccupancyForApartment(Guid apartId, 
            [FromQuery] ApartmentParameters apartParameters)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            var occupDto = CreateOccupancyDtoFromApartParameters(apartId, userId, apartParameters);
            var occup = await _service.OccupancyService
                .CreateOccupancyForApartmentAsync(userId, apartId, occupDto, 
                    userTrackChanges: true, apartTrackChanges: true, occupTrackChanges: false);

            return Ok(occup);
        }

        private OccupancyForCreationDto CreateOccupancyDtoFromApartParameters(Guid apartId,
            string userId, ApartmentParameters apartmentParameters)
        {
            throw new NotImplementedException();
        }
    }
}
