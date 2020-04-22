using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Approve.Services
{
    public class LoadEventService
    {
        public IEnumerable<string> LoadEvent<T>()
        {
            var eventName = typeof(T).Name;
            var eventFiles = Directory.GetFiles(GetEventPath(), "*.json");
                //.Where(file => file.Contains(eventName));
            
            return eventFiles;
        }

        private string GetEventPath()
        {
            var path =  Path.Combine(Path.GetTempPath(), "TimeTrackingSystemEvents");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return path;
        }
    }
}