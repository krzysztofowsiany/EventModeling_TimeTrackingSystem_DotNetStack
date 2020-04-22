using SubmitTimesheet.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace SubmitTimesheet.Controllers
{
    [Route("api/[controller]")]
    public class TimesheetController : Controller
    {
        private IMediator _mediator;
        private SaveEventService _saveEventService;

        public TimesheetController(IMediator mediator)
        {
            _mediator = mediator;
            _saveEventService = new SaveEventService();
        }
        
        [HttpGet("[action]")]
        public IActionResult WeatherForecasts()
        {
            return Ok("");
        }
    }
}
