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
    [Authorize]
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

        [HttpGet(Name = "GetOccupanciesForUser")]
        public async Task<IActionResult> GetOccupanciesForUser(Guid userId)
        {
            userId = Guid.Parse(this.HttpContext.User
                .FindFirstValue(ClaimTypes.NameIdentifier)!);

            var occups = await _service.OccupancyService
                .GetOccupanciesForUserAsync(userId, trackChanges: false);

            return Ok(occups);
        }

        [HttpGet(Name = "GetOccupanciesForApartment")]
        public async Task<IActionResult> GetOccupanciesForApartment(Guid apartId)
        {
            var occups = await _service.OccupancyService
                .GetOccupanciesForApartmentAsync(apartId, trackChanges: false);

            return Ok(occups);
        }

        [HttpGet("{id:guid}", Name = "GetOccupancy")]
        public async Task<IActionResult> GetOccupancy(Guid occupId)
        {
            var occup = await _service.OccupancyService
                .GetOccupancyByIdAsync(occupId, trackChanges: false);

            return Ok(occup);
        }

        [HttpPost("{id:guid}", Name = "CreateOccupancyForApartment")]
        public async Task<IActionResult> CreateOccupancyForApartment(Guid apartId, 
            [FromQuery] ApartmentParameters apartParameters)
        {
            Guid.TryParse(this.User.FindFirst(ClaimTypes.NameIdentifier)!.Value, out Guid userId);
            var occupDto = CreateOccupancyDtoFromApartParameters(apartId, userId, apartParameters);
            var occup = await _service.OccupancyService
                .CreateOccupancyForUserAndApartmentAsync(userId, apartId, occupDto, 
                    userTrackChanges: true, apartTrackChanges: true, occupTrackChanges: false);

            return Ok(occup);
        }

        private OccupancyForCreationDto CreateOccupancyDtoFromApartParameters(Guid apartId,
            Guid userId, ApartmentParameters apartmentParameters)
        {
            return new OccupancyForCreationDto
            {
                OccupancyDate = apartmentParameters.OccupDate,
                EvictionDate = apartmentParameters.EvicDate,
            };
        }

        [HttpDelete("{id:guid}",Name = "DeleteOccupancy")]
        public async Task<IActionResult> DeleteOccupancy(Guid occupId)
        {
            await _service.OccupancyService
                .DeleteOccupancyAsync(occupId, trackChanges: false);

            return NoContent();
        }
    }
}
