using ActionFilter;
using AraWeb.ActionFilters;
using AraWeb.Presentation.ModelBinder;
using Entities.Exceptions;
using Entities.LinkModels;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;
using Shared.RequestFeatures;
using System.Text.Json;

namespace AraWeb.Presentation
{
    [Route("[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ApartmentsController(IServiceManager service)
            => _service = service;

        [HttpGet(Name = "GetApartments")]
        [ServiceFilter(typeof(ValidateMediaTypeAttribute))]
        public async Task<IActionResult> GetApartments([FromQuery] ApartmentParameters apartmentParameters)
        {
            var linkParams = new LinkParameters(apartmentParameters, HttpContext);

            var result = await _service.ApartmentService
                .GetAllApartmentsAsync(linkParams, trackChanges: false);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.metaData));

            return result.linkResponse.HasLinks ? Ok(result.linkResponse.LinkedEntities) :
                Ok(result.linkResponse.ShapedEntities);
        }

        [HttpGet("collection/{ids}", Name = "ApartmentCollection")]
        public async Task<IActionResult> GetApartmentCollection([ModelBinder(BinderType = 
            typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            var apartments = await _service.ApartmentService.GetApartmentsByIdsAsync(ids,
                trackChanges: false);

            return Ok(apartments);
        }

        [HttpGet("userApartments", Name = "GetApartmentsForOwner")]
        public async Task<IActionResult> GetApartmentsForOwner(Guid userId)
        {
            var aparts = await _service.ApartmentService.GetApartmentsForOwnerAsync(userId, 
                trackChanges: false);

            return Ok(aparts);
        }

        [HttpGet("{id:guid}", Name = "GetApartmentById")]
        public async Task<IActionResult> GetApartmentById(Guid id)
        {
            var apartment = await _service.ApartmentService
                .GetApartmentByIdAsync(id, trackChanges: false);

            return Ok(apartment);
        }

        [HttpPost(Name = "CreateApartment")]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> CreateApartment(Guid userId, [FromBody] ApartmentForCreationDto apartment)
        {
            var createdApart = await _service.ApartmentService
                .CreateApartmentForUserAsync(userId, apartment, trackChanges: false);

            return CreatedAtRoute("GetApartmentById", new { id = createdApart.Id }, createdApart);
        }

        [HttpPost("collection", Name = "CreateApartmentCollection")]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> CreateApartmentCollection(
            IEnumerable<ApartmentForCreationDto> apartments)
        {
            var result = await _service.ApartmentService.CreateApartmentCollectionAsync(apartments);

            return Ok(result);
        }

        [HttpDelete("{id:guid}", Name = "DeleteApartment")]
        public async Task<IActionResult> DeleteApartment(Guid id)
        {
            await _service.ApartmentService.DeleteApartmentAsync(id, trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:guid}", Name = "UpdateApartment")]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> UpdateApartment(Guid id, [FromBody] ApartmentForUpdateDto apartment)
        {
            if (apartment is null)
                return BadRequest("ApartmentForUpdateDto object is null.");

            await _service.ApartmentService.UpdateApartmentAsync(id, apartment, trackChanges: true);

            return NoContent();
        }

        [HttpPatch("{id:guid}", Name = "ParticallyUpdateApartment")]
        [ServiceFilter(typeof(AsyncValidationFilterAttribute))]
        public async Task<IActionResult> ParticallyUpdateApartment(Guid id, 
            [FromBody] JsonPatchDocument<ApartmentForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("PatchDoc object sent from client is null.");

            var result = await _service.ApartmentService.GetApartmentForPatchAsync(id, 
                trackChanges: true);
            patchDoc.ApplyTo(result.apartmentToPatch);

            await _service.ApartmentService.SaveChangesForPatchAsync(result.apartmentToPatch, 
                result.apartmentEntity);

            return NoContent();
        }
    }
}
