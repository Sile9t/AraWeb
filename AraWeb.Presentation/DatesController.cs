using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Presentation
{
    [Route("calendar")]
    [ApiController]
    [Authorize]
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
        public async Task<IActionResult> GetDatesForUser(Guid userId)
        {
            var dates = await _service.ReservationDateService
                .GetDatesForUserAsync(userId, trackChanges: false);

            return Ok(dates);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDate(Guid apartId, 
            [FromBody]ReservationDateForCreationDto dateDto)
        {
            await _service.ReservationDateService.CreateDateForApartmentAsync(apartId, dateDto,
                trackChanges: false);

            return NoContent();
        }

        //To do: GetDatesForUserApartments(Guid userId),
        //PartiallyUpdateDateCollection(Guid apartId, ICollection<ReservationDateForUpdate)
    }
}
