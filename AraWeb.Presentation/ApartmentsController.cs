﻿using AraWeb.Presentation.ModelBinder;
using Entities.Exceptions;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

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
        public IActionResult GetApartments()
        {
            var apartments = _service.ApartmentService
                .GetAllApartments(trackChanges: false);

            return Ok(apartments);
        }

        [HttpGet("collection/{ids}", Name = "ApartmentCollection")]
        public IActionResult GetApartmentCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]
            IEnumerable<Guid> ids)
        {
            var apartments = _service.ApartmentService.GetApartmentsByIds(ids,
                trackChanges: false);

            return Ok(apartments);
        }

        [HttpGet("{id:guid}", Name = "GetApartmentById")]
        public IActionResult GetApartmentById(Guid id)
        {
            var apartment = _service.ApartmentService
                .GetApartmentById(id, trackChanges: false);

            return Ok(apartment);
        }

        [HttpPost(Name = "CreateApartment")]
        public IActionResult CreateApartment([FromBody] ApartmentForCreationDto apartment)
        {
            var createdApart = _service.ApartmentService.CreateApartment(apartment);

            return CreatedAtRoute("GetApartmentById", new { id = createdApart.Id }, createdApart);
        }

        [HttpPost("collection", Name = "CreateApartmentCollection")]
        public IActionResult CreateApartmentCollection(IEnumerable<ApartmentForCreationDto> apartments)
        {
            var result = _service.ApartmentService.CreateApartmentCollection(apartments);

            return Ok(result);
        }

        [HttpDelete("{id:guid}", Name = "DeleteApartment")]
        public IActionResult DeleteApartment(Guid id)
        {
            _service.ApartmentService.DeleteApartment(id, trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateApartment(Guid id, [FromBody] ApartmentForUpdateDto apartment)
        {
            if (apartment is null)
                return BadRequest("ApartmentForUpdateDto object is null");

            _service.ApartmentService.UpdateApartment(id, apartment, trackChanges: true);

            return NoContent();
        }

        [HttpPatch("{id:guid}", Name = "ParticallyUpdateApartment")]
        public IActionResult ParticallyUpdateApartment(Guid id, 
            [FromBody] JsonPatchDocument<ApartmentForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("PatchDoc object sent from client is null.");

            var result = _service.ApartmentService.GetApartmentForPatch(id, trackChanges: false);
            patchDoc.ApplyTo(result.apartmentToPatch);

            _service.ApartmentService.SaveChangesForPatch(result.apartmentToPatch, 
                result.apartmentEntity);

            return NoContent();
        }
    }
}
