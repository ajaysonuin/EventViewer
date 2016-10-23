using Log.Services.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Services.Events
{
    public class EventLogService : IEventLogService
    {
        #region Events
        public IList<EventModel> GetAllEvents(string name = "")
        {
            if (string.IsNullOrEmpty(name))
                name = "";
            var eventLogs = EventLog.GetEventLogs();
            var eventList = new List<EventModel>();
            foreach (var log in eventLogs)
            {
                eventList.Add(new EventModel()
                {
                    Name = log.Log,
                    DisplayName = log.LogDisplayName,
                    MachineName = log.MachineName
                });
            }

            return eventList.Where(m => m.DisplayName.ToLower().Contains(name.ToLower()) || m.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public EventModel GetEvent(string name)
        {
            var eventLog = GetAllEvents(name).FirstOrDefault();
            return eventLog;
        }
        #endregion

        #region Logs
        public IList<LogModel> GetAllLogs(string logname, string source = "")
        {
            if (string.IsNullOrEmpty(logname))
                logname = "";
            if (string.IsNullOrEmpty(source))
                source = "";
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
        #endregion
    }
}
