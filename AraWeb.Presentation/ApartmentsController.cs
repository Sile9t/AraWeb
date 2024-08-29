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

        [HttpGet("{id:guid}", Name = "GetApartmentById")]
        public IActionResult GetApartment(Guid id)
        {
            var apartment = _service.ApartmentService
                .GetApartmentById(id, trackChanges: false);

            return Ok(apartment);
        }

        [HttpPost]
        public IActionResult CreateApartment([FromBody] ApartmentForCreationDto apartment)
        {
            if (apartment is null)
                return BadRequest("ApartmentForCreationDto object is null.");

            var createdApart = _service.ApartmentService.CreateApartment(apartment);

            return CreatedAtRoute("GetApartmentById", new {id = createdApart.Id}, createdApart);
        }
    }
}
