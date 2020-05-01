using System;
using System.IO;
using Approve.Commands;
using Approve.Events;
using Approve.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Approve.Controllers
{
    [Route("api/[controller]")]
    public class TimesheetController : Controller
    {
        private LoadEventService _loadEventService;
        private IMediator _mediator;

        public TimesheetController(IMediator mediator)
        {
            _mediator = mediator;
            _loadEventService = new LoadEventService();
        }
        
        [HttpGet("approve")]
        public IActionResult Approve(Guid timesheetId, Guid userId)
        {
            _mediator.Send(new ApproveTimesheet(timesheetId, userId));
            return Ok($"save event");
        }

        [HttpGet("get")]
        public IActionResult GetEvents()
        {
            return Ok(_loadEventService.LoadEvent<TimesheetApproved>());
        }
    }
}