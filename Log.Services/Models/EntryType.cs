using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log.Services.Models
{
    public enum EntryType
    {
        Error = 1,
        Warning = 2,
        Information = 4,
        SuccessAudit = 8,
        FailureAudit = 16
    }
}