using System;
using MediatR;

namespace Approve.Commands
{
    public class ApproveTimesheet :  IRequest
    {
        public ApproveTimesheet(Guid timesheetId, Guid userId)
        {
            TimesheetId = timesheetId;
            UserId = userId;
        }

        public Guid TimesheetId { get;  }       
        public Guid UserId { get;  }       
    }
}