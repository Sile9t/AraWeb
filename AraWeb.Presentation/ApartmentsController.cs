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

        [HttpGet(Name = "Apartments")]
        public IActionResult Apartments()
        {
            var apartments = _service.ApartmentService
                .GetAllApartments(trackChanges: false);

            return Ok(apartments);
        }

        [HttpGet("{id:guid}", Name = "ApartmentById")]
        public IActionResult ApartmentById(Guid id)
        {
            var apartment = _service.ApartmentService
                .GetApartmentById(id, trackChanges: false);

            return Ok(apartment);
        }

        [HttpPost(Name = "CreateApartment")]
        public IActionResult CreateApartment([FromBody] ApartmentForCreationDto apartment)
        {
            if (apartment is null)
                return BadRequest("ApartmentForCreationDto object is null.");

            var createdApart = _service.ApartmentService.CreateApartment(apartment);

            return CreatedAtRoute("ApartmentById", new {id = createdApart.Id}, createdApart);
        }
    }
}
