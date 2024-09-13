using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.Dtos;

namespace AraWeb.Presentation
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpGet("apartments")]
        public async Task<IActionResult> MyApartments()
        {
            var aparts = await _service.ApartmentService
                .GetApartmentsForOwnerAsync(_user.Id, trackChanges: false);

            return Ok(aparts);
        }

        [HttpGet("calendar")]
        public async Task<IActionResult> MyCalendar()
        {
            var aparts = await _service.ApartmentService
                .GetApartmentsForOwnerAsync(_user.Id, trackChanges: false);

            var dates = await _service.ReservationDateService
                .GetDatesForApartmentsAsync(aparts.Select(a => a.Id), trackChanges: false);

            return Ok((aparts, dates));
        }

        [HttpGet("occupancies")]
        public async Task<IActionResult> MyOccupancies()
        {
            var occups = await _service.OccupancyService
                .GetOccupanciesForUserAsync(_user.Id, trackChanges: false);

            return Ok(occups);
        }
    }
}
