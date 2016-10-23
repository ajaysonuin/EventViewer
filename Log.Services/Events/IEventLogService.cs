using Log.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Services.Events
{
    public interface IEventLogService
    {
        #region Events
        IList<EventModel> GetAllEvents(string name = "");

        EventModel GetEvent(string name);
        #endregion

        #region Logs
        IList<LogModel> GetAllLogs(string logname, string source = "");

        LogModel GetLog(string logname, string source, int instanceId);
        #endregion
    }
}
