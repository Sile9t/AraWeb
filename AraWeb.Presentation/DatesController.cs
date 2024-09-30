using AraWeb.ActionFilters;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;
using System.Security.Claims;

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

        //TODO: Redirect all routes to main calendar route
        [HttpGet("{id:guid}", Name = "GetDatesForUser")]
        public async Task<IActionResult> GetDatesForUser(Guid userId)
        {
            userId = Guid.Parse(this.HttpContext.User
                .FindFirst(ClaimTypes.NameIdentifier)!.Value);

            var dates = await _service.ReservationDateService
                .GetDatesForUserAsync(userId, trackChanges: false);

            return Ok(dates);
        }

        [HttpPost(Name = " CreateDateForApartment")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateDateForApartment(Guid apartId, 
            [FromBody]ReservationDateForCreationDto dateDto)
        {
            await _service.ReservationDateService.CreateDateForApartmentAsync(apartId, dateDto,
                trackChanges: false);

            return NoContent();
        }

        [HttpPost("collection", Name = "CreateDateCollection")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateDateCollection(Guid apartId, 
            [FromBody] IEnumerable<ReservationDateForCreationDto> dateDtos)
        {
            await _service.ReservationDateService
                .CreateDateCollectionForApartmentAsync(apartId, dateDtos, trackChanges: false);

            return NoContent();
        }

        [HttpDelete(Name = "DeleteDateForApartment")]
        public async Task<IActionResult> DeleteDateForApartment(Guid apartId, DateTime date)
        {
            await _service.ReservationDateService
                .DeleteDateForApartmentAsync(apartId, date, trackChanges: false);

            return NoContent();
        }

        [HttpDelete("collection", Name = "DeleteDatesForApartment")]
        public async Task<IActionResult> DeleteDatesForApartment(Guid apartId, 
            [FromQuery]IEnumerable<DateTime> dateRange)
        {
            await _service.ReservationDateService
                .DeleteDateCollectionForApartmentAsync(apartId, dateRange, trackChanges: false);

            return NoContent();
        }

        [HttpPut(Name = "UpdateDateForApartment")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateDateForApartment(Guid apartId, 
            [FromBody] ReservationDateForUpdateDto dateForUpdate)
        {
            await _service.ReservationDateService
                .UpdateDateForApartmentAsync(dateForUpdate, apartTrackChanges: false, dateTrackChanges: false);

            return NoContent();
        }


        [HttpPut("collection", Name = "UpdateDatesForApartment")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateDatesForApartment(Guid apartId, 
            [FromBody] IEnumerable<ReservationDateForUpdateDto> datesForUpdate)
        {
            await _service.ReservationDateService
                .UpdateDateCollectionForApartmentAsync(datesForUpdate, trackChanges: false);

            return NoContent();
        }

        [HttpPatch(Name = "PartiallyUpdateDateForApartment")]
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

        [HttpPatch("collection", Name = "PartialluUpdateDatesForApartment")]
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
