using System;
using System.IO;
using Approve.Events;
using Approve.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Approve.Controllers
{
    [Route("api/[controller]")]
    public class TimesheetController : Controller
    {
        private SaveEventService _saveEventService;

        public TimesheetController()
        {
            _saveEventService = new SaveEventService();
        }
        
        [HttpGet("approve")]
        public IActionResult Approve(Guid timesheetId, Guid userId)
        {
            var dateTime = DateTime.UtcNow;
            
            var timesheetApproved = new TimesheetApproved(timesheetId,userId, dateTime);
            
            var fileName = _saveEventService.SaveEvent(timesheetApproved, dateTime);
            return Ok($"save file to: {fileName}");
        }
    }
}