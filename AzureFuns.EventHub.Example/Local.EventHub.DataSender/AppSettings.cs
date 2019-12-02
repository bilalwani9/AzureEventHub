﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Local.EventHub.DataSender
{
    public class AppSettings : IAppSettings
    {
        public string EmployeesDataFileName { get; set; }
        public string EventHubConnectionString { get; set; }
        public string EventHubName { get; set; }
    }
}
