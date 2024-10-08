﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System.Security.Claims;

namespace AraWeb.Presentation.Views
{
    [Route("[controller]/{id:guid}")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly IServiceManager _service;

        public AccountController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            bool hasId = TryGetLoggedUserId(out var userId);

            if (!hasId) return NoContent();

            var user = await _service.UserService.GetUserByIdAsync(userId!, trackChanges: false);

            return Ok(user);
        }

        [HttpGet("apartments")]
        public async Task<IActionResult> MyApartments()
        {
            bool hasId = TryGetLoggedUserId(out var userId);

            if (!hasId) return NoContent();

            var aparts = await _service.ApartmentService
                .GetApartmentsForOwnerAsync(userId!, trackChanges: false);

            return Ok(aparts);
        }

        [HttpGet("calendar")]
        public async Task<IActionResult> MyCalendar()
        {
            bool hasId = TryGetLoggedUserId(out var userId);

            if (!hasId) return NoContent();

            var aparts = await _service.ApartmentService
                .GetApartmentsForOwnerAsync(userId!, trackChanges: false);

            var dates = await _service.ReservationDateService
                .GetDatesForApartmentsAsync(aparts.Select(a => a.Id), trackChanges: false);

            return Ok((aparts, dates));
        }

        [HttpGet("occupancies")]
        public async Task<IActionResult> MyOccupancies()
        {
            bool hasId = TryGetLoggedUserId(out var userId);

            if (!hasId) return NoContent();

            var occups = await _service.OccupancyService
                .GetOccupanciesForUserAsync(userId!, trackChanges: false);

            return Ok(occups);
        }

        private bool TryGetLoggedUserId(out Guid userId) =>
            Guid.TryParse(User.FindFirstValue(ClaimTypes.NameIdentifier), out userId);
    }
}
