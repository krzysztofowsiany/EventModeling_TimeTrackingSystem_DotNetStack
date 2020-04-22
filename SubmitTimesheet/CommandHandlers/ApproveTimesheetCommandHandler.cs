using System;
using Approve.Commands;
using Approve.Events;
using Approve.Services;
using MediatR;

namespace Approve.CommandHandlers
{
    public class ApproveTimesheetCommandHandler : RequestHandler<ApproveTimesheet>
    {
        private SaveEventService _saveEventService;

        public ApproveTimesheetCommandHandler(SaveEventService saveEventService)
        {
            _saveEventService = saveEventService;
        }
        
        protected override void Handle(ApproveTimesheet command)
        {
            var dateTime = DateTime.UtcNow;
                        
            
            var timesheetApproved = new TimesheetApproved(command.TimesheetId,command.UserId, dateTime);
            
            _saveEventService.SaveEvent(timesheetApproved, dateTime);
        }
    }
}