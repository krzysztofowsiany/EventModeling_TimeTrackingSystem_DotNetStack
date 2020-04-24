using System;

namespace HourlyRate.Events
{
    public class HourlyRateDefined
    {
        public HourlyRateDefined( Guid userId, short hourlyRate, DateTime timestamp)
        {
            UserId = userId;
            HourlyRate = hourlyRate;
            Timestamp = timestamp;
        }

        public short HourlyRate { get;  }       
        public Guid UserId { get;  }       
        public DateTime Timestamp { get;  }       
    }
}