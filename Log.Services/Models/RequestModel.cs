﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Log.Services.Models
{
    public class RequestModel
    {
        public int instanceId { get; set; }
        public string name { get; set; }
        public string source { get; set; }
    }
}