using AraWeb.ActionFilters;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
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
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateDateForApartment(Guid apartId, 
            [FromBody]ReservationDateForCreationDto dateDto)
        {
            await _service.ReservationDateService.CreateDateForApartmentAsync(apartId, dateDto,
                trackChanges: false);

            return NoContent();
        }

        [HttpPost("collection")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateDateCollection(Guid apartId, 
            [FromBody] IEnumerable<ReservationDateForCreationDto> dateDtos)
        {
            await _service.ReservationDateService
                .CreateDateCollectionForApartmentAsync(apartId, dateDtos, trackChanges: false);

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDateForApartment(Guid apartId, DateTime date)
        {
            await _service.ReservationDateService
                .DeleteDateForApartmentAsync(apartId, date, trackChanges: false);

            return NoContent();
        }

        [HttpDelete("collection")]
        public async Task<IActionResult> DeleteDatesForApartment(Guid apartId, 
            IEnumerable<DateTime> dateRange)
        {
            await _service.ReservationDateService
                .DeleteDateCollectionForApartmentAsync(apartId, dateRange, trackChanges: false);

            return NoContent();
        }

        [HttpPut]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateDateForApartment(Guid apartId, 
            [FromBody] ReservationDateForUpdateDto dateForUpdate)
        {
            await _service.ReservationDateService
                .UpdateDateForApartmentAsync(dateForUpdate, apartTrackChanges: false, dateTrackChanges: false);

            return NoContent();
        }


        [HttpPut("collection")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateDatesForApartment(Guid apartId, 
            [FromBody] IEnumerable<ReservationDateForUpdateDto> datesForUpdate)
        {
            await _service.ReservationDateService
                .UpdateDateCollectionForApartmentAsync(datesForUpdate, trackChanges: false);

            return NoContent();
        }

        [HttpPatch]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> PartiallyUpdateDateForApartment(Guid apartId, DateTime date,
            [FromBody] JsonPatchDocument<ReservationDateForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("PatchDoc object sent from client is null.");

            var result = await _service.ReservationDateService
                .GetDateForApartmentToPatchAsync(apartId, date, trackChanges: true);
            patchDoc.ApplyTo(result.dateToPatch);

            await _service.ReservationDateService
                .SaveChangesForPatchAsync(result.dateToPatch, result.dateEntity);

            return NoContent();
        }

        [HttpPatch("collection")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> PartiallyUpdateDatesForApartment(Guid apartId, 
            IEnumerable<DateTime> dateRange,
            [FromBody] JsonPatchDocument<IEnumerable<ReservationDateForUpdateDto>> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("PatchDoc object sent from client is null.");

            var result = await _service.ReservationDateService
                .GetDatesForApartmentToPatchAsync(apartId, dateRange, trackChanges: true);
            if (result.datesToPatch is null || result.dateEntities is null)
                return NoContent();

            patchDoc.ApplyTo(result.datesToPatch);

            await _service.ReservationDateService
                .SaveChangesForPatchAsync(result.datesToPatch, result.dateEntities);

            return NoContent();
        }
    }
}
