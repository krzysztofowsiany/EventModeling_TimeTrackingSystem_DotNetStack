using HourlyRate.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HourlyRate.Controllers
{
    [Route("api/[controller]")]
    public class RateController : Controller
    {
        private readonly IMediator _mediator;

        public RateController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost("setHourlyRate")]
        public IActionResult SetHourlyRate([FromBody] SetHourlyRate command)
        {
            _mediator.Send(command);
            return Ok("SetHourlyRate");
        }
    }
}