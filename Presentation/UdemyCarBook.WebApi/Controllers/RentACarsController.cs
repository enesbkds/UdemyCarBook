﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.RentACarQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RentACarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetRentACarListByLocation(int locationID, bool avaliable)
        {
            GetRentACarQuery getRentACarQuery = new GetRentACarQuery()
            {
                Avaliable = avaliable,
                LocationID = locationID
            };
            var values = await _mediator.Send(getRentACarQuery);
            return Ok(values);
        }
    }
}