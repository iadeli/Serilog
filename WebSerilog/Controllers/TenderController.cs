using Serilog;
using Serilog.Core;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebSerilog.Controllers
{
    public class TenderController : ApiController
    {
        public void Get()
        {
            Framework.Core.Logger.Current.Information("UserId = {@User}, Login = {@Status}", 10, "Success");
        }
    }
}
