using MediatR;
using Microsoft.AspNetCore.Mvc;
using Requests_.simpleThoughts.Commands.Commands;
using Requests_.simpleThoughts.Queries.Queries;

namespace SimpleThoughts.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PingController(IMediator _mediator)
        {
            this._mediator = _mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Ping() => Ok(await _mediator.Send(new PingCommand()));

        [HttpGet("Query")]
        public async Task<IActionResult> PingQuery() => Ok(await _mediator.Send(new PingQuery()));

    }
}
