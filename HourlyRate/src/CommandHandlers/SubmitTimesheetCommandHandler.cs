using System;
using HourlyRate.Commands;
using HourlyRate.Services;
using MediatR;
using HourlyRate.Events;

namespace HourlyRate.CommandHandlers
{
    public class SetHourlyRateCommandHandler : RequestHandler<SetHourlyRate>
    {
        private SaveEventService _saveEventService;

        public SetHourlyRateCommandHandler(SaveEventService saveEventService)
        {
            _saveEventService = saveEventService;
        }

        protected override void Handle(SetHourlyRate command)
        {
            var dateTime = DateTime.UtcNow;

            var @event = new HourlyRateDefined(
                command.UserId,
                command.HourlyRate,
                dateTime);

            _saveEventService.SaveEvent(@event, dateTime);
        }
    }
}