using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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

        [HttpPost]
        public async Task<IActionResult> CreateDate([FromBody]ReservationDate reservationDate)
        {
            await _service.ReservationDateService.CreateDateAsync(reservationDate);

            return NoContent();
        }
    }
}
