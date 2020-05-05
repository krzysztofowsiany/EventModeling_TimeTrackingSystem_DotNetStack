using System;
using System.IO;
using Newtonsoft.Json;

namespace HourlyRate.Services
{
    public class SaveEventService
    {
        public string SaveEvent<T>(T timesheetApproved, DateTime dateTime)
        {
            var time = dateTime.Ticks.ToString();
            
            var fileName = $"{time}_{typeof(T).Name}.json";
            
            var eventString =  JsonConvert.SerializeObject(timesheetApproved);

            var eventPath = PathProvider.GetEventPath();
            var filePath = Path.Combine(eventPath, fileName);
            
            System.IO.File.WriteAllText(filePath, eventString);
            
            return filePath;
        }
    }
}