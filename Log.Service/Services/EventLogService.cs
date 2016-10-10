using Log.Service.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Log.Service.Services
{
    public class EventLogService
    {
        private readonly LogService _logService;
        public EventLogService()
        {
            _logService = new LogService();
        }

        public IList<EventModel> GetAllEvents(string name = "")
        {
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
            var eventLog= GetAllEvents(name).FirstOrDefault();
            return eventLog;
        }
    }
}