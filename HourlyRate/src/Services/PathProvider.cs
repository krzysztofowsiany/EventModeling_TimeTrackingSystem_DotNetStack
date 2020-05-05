using System;
using System.IO;

namespace HourlyRate.Services
{
    static class PathProvider
    {
        internal static string GetEventPath()
        {           
            var eventPath =  Environment.GetEnvironmentVariable("EVENT_PATH");

            if (Directory.Exists(eventPath))
                return eventPath;
            
            var path =  Path.Combine(Path.GetTempPath(), eventPath);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            return path;
        }
    }
}