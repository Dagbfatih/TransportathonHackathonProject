﻿using Core.API.Controllers;
using Core.Persistence.Pagination;
using Microsoft.AspNetCore.Mvc;
using TransportathonHackathon.Application.Features.Carriers.Commands.Create;
using TransportathonHackathon.Application.Features.Carriers.Commands.Delete;
using TransportathonHackathon.Application.Features.Carriers.Commands.Update;
using TransportathonHackathon.Application.Features.Carriers.Queries.GetByCompanyId;
using TransportathonHackathon.Application.Features.Carriers.Queries.GetById;
using TransportathonHackathon.Application.Features.Carriers.Queries.GetList;

namespace TransportathonHackathon.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarriersController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCarrierCommand command)
        {
            CreatedCarrierResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteCarrierCommand command)
        {
            DeletedCarrierResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCarrierCommand command)
        {
            UpdatedCarrierResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{EmployeeId}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdCarrierQuery command)
        {
            GetByIdCarrierResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{CompanyId}")]
        public async Task<IActionResult> GetByCompanyId([FromRoute] GetByCompanyIdCarrierQuery command)
        {
            IList<GetByCompanyIdCarrierResponse> response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListCarrierQuery command)
        {
            IPaginate<GetListCarrierResponse> response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}
