using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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
    }
}
