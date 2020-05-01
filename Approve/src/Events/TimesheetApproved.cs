using System;

namespace Approve.Events
{
    public class TimesheetApproved
    {
        public TimesheetApproved(Guid timesheetId, Guid userId, DateTime timestamp)
        {
            TimesheetId = timesheetId;
            UserId = userId;
            Timestamp = timestamp;
        }

        public Guid TimesheetId { get;  }       
        public Guid UserId { get;  }       
        public DateTime Timestamp { get;  }       
    }
}