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
            throw new Exception("Test Exception");
            var apartments = _service.ApartmentService
                .GetAllApartments(trackChanges: false);

            return Ok(apartments);
        }
    }
}
