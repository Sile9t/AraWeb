using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Presentation
{
    [Route("calendar")]
    [ApiController]
    public class DatesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DatesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDates()
        {
            var dates = await _service.ReservationDateService
                .GetAllDatesAsync(trackChanges: false);

            return Ok(dates);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetDatesForUserApartments(Guid userId)
        {
            var dates = await _service.ReservationDateService
                .GetDatesForUserAsync(userId.ToString(), trackChanges: false);

            return Ok(dates);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDate([FromBody]ReservationDateForCreationDto dateDto)
        {
            await _service.ReservationDateService.CreateDateAsync(dateDto);

            return NoContent();
        }
    }
}
