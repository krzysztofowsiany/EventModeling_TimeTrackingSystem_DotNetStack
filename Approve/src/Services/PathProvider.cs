using System.IO;

namespace Approve.Services
{
    static class PathProvider
    {
        internal static string GetEventPath()
        {
            var path =  Path.Combine(Path.GetTempPath(), "TimeTrackingSystemEvents");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            
            return path;
        }
    }
}