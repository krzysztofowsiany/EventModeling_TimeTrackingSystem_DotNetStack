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
            var eventFiles = Directory.GetFiles(PathProvider.GetEventPath(), "*.json");
                //.Where(file => file.Contains(eventName));
            
            return eventFiles;
        }
    }
}