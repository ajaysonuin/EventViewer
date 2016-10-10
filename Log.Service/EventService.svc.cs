using Log.Service.Entities;
using Log.Service.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Log.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EventService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EventService.svc or EventService.svc.cs at the Solution Explorer and start debugging.
    public class EventService : IEventService
    {
        private readonly EventLogService _eventService;
        private readonly LogService _logService;
        public EventService()
        {
            _eventService = new EventLogService();
            _logService = new LogService();
        }
        public IList<EventModel> GetAllEvents(string name)
        {
            return _eventService.GetAllEvents(name);
        }

        public EventModel GetEvent(string name)
        {
            return _eventService.GetEvent(name);
        }

        public IList<LogModel> GetAllLogs(string source,string name)
        {
            return _logService.GetAllLogs(name, source);
        }

        public LogModel GetLog(string instanceId, string source,string name)
        {
            return _logService.GetLog(name, source, int.Parse(instanceId));
        }
    }
}
