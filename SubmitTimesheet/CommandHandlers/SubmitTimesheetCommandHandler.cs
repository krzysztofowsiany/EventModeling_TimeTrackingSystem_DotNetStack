using System;
using MediatR;
using SubmitTimesheet.Services;
using SubmitTimesheet.Events;

namespace SubmitTimesheet.CommandHandlers
{
    public class SubmitTimesheetCommandHandler : RequestHandler<Commands.SubmitTimesheet>
    {
        private SaveEventService _saveEventService;

        public SubmitTimesheetCommandHandler(SaveEventService saveEventService)
        {
            _saveEventService = saveEventService;
        }

        protected override void Handle(Commands.SubmitTimesheet command)
        {
            var dateTime = DateTime.UtcNow;

            var @event = new TimesheetSubmitted(
                command.TimesheetId,
                command.UserId,
                command.StartDate,
                command.EndDate,
                dateTime);

            _saveEventService.SaveEvent(@event, dateTime);
        }
    }
}