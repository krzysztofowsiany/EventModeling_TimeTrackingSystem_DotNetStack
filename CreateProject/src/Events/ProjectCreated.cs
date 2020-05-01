﻿using System;

namespace CreateProject.Events
{
    public class ProjectCreated
    {
        public ProjectCreated(Guid projectId, Guid projectOwnerId, string name, DateTime timestamp)
        {
            ProjectId = projectId;
            ProjectOwnerId = projectOwnerId;
            Name = name;
            Timestamp = timestamp;
        }

        public Guid ProjectId { get;  }       
        public Guid ProjectOwnerId { get;  }       
        public string Name { get;  }     
        public DateTime Timestamp { get;  }       

    }
}