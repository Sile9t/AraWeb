﻿using AraWeb.Presentation.ModelBinder;
using Entities.Exceptions;
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

            return  Ok(result);
        }
    }
}
