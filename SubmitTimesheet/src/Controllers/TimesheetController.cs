using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SubmitTimesheet.Controllers
{
    [Route("api/[controller]")]
    public class TimesheetController : Controller
    {
        private IMediator _mediator;

        public TimesheetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("submitTimesheet")]
        public IActionResult SubmitTimesheet([FromBody] Commands.SubmitTimesheet command)
        {
            _mediator.Send(command);
            return Ok("submitted");
        }

        [HttpGet("ping")]
        public IActionResult Pong()
        {
            return Ok("pong");
        }
    }
}