﻿using Core.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using TransportathonHackathon.Application.Features.Languages.Commands.Create;
using TransportathonHackathon.Application.Features.Languages.Commands.Delete;
using TransportathonHackathon.Application.Features.Languages.Commands.Update;
using TransportathonHackathon.Application.Features.Languages.Queries.GetByCode;
using TransportathonHackathon.Application.Features.Languages.Queries.GetById;
using TransportathonHackathon.Application.Features.Languages.Queries.GetList;

namespace TransportathonHackathon.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LanguagesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateLanguageCommand command)
        {

            CreatedLanguageResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteLanguageCommand command)
        {
            DeletedLanguageResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateLanguageCommand command)
        {
            UpdatedLanguageResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{Code}")]
        public async Task<IActionResult> GetByCode([FromRoute] GetByCodeLanguageQuery command)
        {
            GetByCodeLanguageResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdLanguageQuery command)
        {
            GetByIdLanguageResponse response = await Mediator.Send(command);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] GetListLanguageQuery command)
        {
            List<GetListLanguageResponse> response = await Mediator.Send(command);
            return Ok(response);
        }
    }
}