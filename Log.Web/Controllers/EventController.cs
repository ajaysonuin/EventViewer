using Log.Services.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Log.Web.Controllers
{
    public class EventController : ApiController
    {
        private readonly IEventLogService _eventLogService;
        public EventController(IEventLogService eventLogService)
        {
            this._eventLogService = eventLogService;
        }

        [HttpGet]
        public IHttpActionResult GetAllEvents(string name="")
        {
            var model = _eventLogService.GetAllEvents(name);
            return Ok(model);
        }

        [HttpGet]
        public IHttpActionResult GetEvent(string name="")
        {
            var model = _eventLogService.GetEvent(name);
            return Ok(model);
        }

        [HttpGet]
        public IHttpActionResult GetAllLogs(string name, string source = "")
        {
            var model = _eventLogService.GetAllLogs(name, source);
            return Ok(model);
        }

        [HttpGet]
        public IHttpActionResult GetLog(string instanceId,string name, string source="")
        {
            var model = _eventLogService.GetLog(name, source, int.Parse(instanceId));
            return Ok(model);
        }
    }
}
