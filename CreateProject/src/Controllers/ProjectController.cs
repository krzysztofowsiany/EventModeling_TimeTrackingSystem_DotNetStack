using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CreateProject.Controllers
{
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public IActionResult CreateProject([FromBody] Commands.CreateProject command)
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