using Log.Service.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Log.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEventService" in both code and config file together.
    [ServiceContract]
    public interface IEventService
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetAllEvents/?name={name}", RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json)]
        IList<EventModel> GetAllEvents(string name);

        [OperationContract]
        [WebGet(UriTemplate = "GetEvent/?name={name}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        EventModel GetEvent(string name);

        [OperationContract]
        [WebGet(UriTemplate = "GetAllLogs/?source={source}&name={name}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<LogModel> GetAllLogs(string name,string source);

        [OperationContract]
        [WebGet(UriTemplate = "GetLog/{instanceId}?source={source}&name={name}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        LogModel GetLog(string instanceId, string source, string name);
    }
}
