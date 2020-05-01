﻿using System;
 using CreateProject.Events;
 using CreateProject.Services;
 using MediatR;

namespace CreateProject.CommandHandlers
{
    public class CreateProjectCommandHandler : RequestHandler<Commands.CreateProject>
    {
        private SaveEventService _saveEventService;

        public CreateProjectCommandHandler(SaveEventService saveEventService)
        {
            _saveEventService = saveEventService;
        }

        protected override void Handle(Commands.CreateProject command)
        {
            var dateTime = DateTime.UtcNow;

            var @event = new ProjectCreated(
                command.ProjectId,
                command.ProjectOwnerId,
                command.Name,
                dateTime);

            _saveEventService.SaveEvent(@event, dateTime);
        }
    }
}