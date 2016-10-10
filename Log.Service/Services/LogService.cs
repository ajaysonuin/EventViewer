using Log.Service.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Log.Service.Services
{
    public class LogService
    {
        public IList<LogModel> GetAllLogs(string logname, string source = "")
        {
            var eventEntries = new List<EventLogEntry>();
            var appEvents = EventLog.GetEventLogs().Where(m => m.Log == logname).FirstOrDefault();
            if (appEvents != null)
                eventEntries = appEvents.Entries.Cast<EventLogEntry>().ToList();

            List<LogModel> logModels = new List<LogModel>();
            foreach (var log in eventEntries)
            {
                logModels.Add(new LogModel()
                {
                    UserName = log.UserName,
                    Category = log.Category,
                    Type = log.EntryType.ToString(),
                    InstanceId = log.InstanceId,
                    MachineName = log.MachineName,
                    Message = log.Message.Replace(". ", Environment.NewLine),
                    Source = log.Source,
                    TimeWritten = log.TimeWritten.ToString(),
                    TimeGenerated = log.TimeGenerated.ToString(),
                });
            }

            return logModels.Where(m => m.Source.ToLower().Contains(source.ToLower())).ToList();
        }

        public LogModel GetLog(string logname, string source, int instanceId)
        {
            return GetAllLogs(logname, source).Where(m => m.InstanceId == instanceId).FirstOrDefault();
        }        
    }
}