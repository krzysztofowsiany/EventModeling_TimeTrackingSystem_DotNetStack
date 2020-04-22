using System;

namespace SubmitTimesheet.Events
{
    public class TimesheetSubmitted
    {
        public TimesheetSubmitted(Guid timesheetId, Guid userId, DateTime startDate, DateTime endDate, DateTime timestamp)
        {
            TimesheetId = timesheetId;
            UserId = userId;
            StartDate = startDate;
            EndDate = endDate;
            Timestamp = timestamp;
        }

        public Guid TimesheetId { get;  }       
        public Guid UserId { get;  }       
        public DateTime StartDate { get;  }       
        public DateTime EndDate { get;  }      
        
        public DateTime Timestamp { get;  }       
    }
}