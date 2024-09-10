using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Presentation
{
    [Route("[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IServiceManager _service;
        private UserDto _user;

        public ProfileController(IServiceManager service)
        {
            _service = service;
            _user = _service.AuthenticationService.GetUserProfile();
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            //var _user = _service.AuthenticationService.GetUserProfile();

            return Ok(_user);
        }

        [HttpGet]
        public async Task<IActionResult> MyApartments()
        {
            var aparts = await _service.ApartmentService
                .GetApartmentsForOwnerAsync(_user.Id, trackChanges: false);

            return Ok(aparts);
        }

        [HttpGet]
        public async Task<IActionResult> MyCalendar()
        {
            var aparts = await _service.ApartmentService
                .GetApartmentsForOwnerAsync(_user.Id, trackChanges: false);

            var dates = await _service.ReservationDateService
                .GetDatesForApartmentsAsync(aparts.Select(a => a.Id), trackChages: false);

            return Ok(aparts, dates);
        }

        [HttpGet]
        public async Task<IActionResult> MyOccupancies()
        {
        }
    }
}
