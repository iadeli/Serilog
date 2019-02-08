using Framework.SimpleInjector;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebSerilog
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            WireUp();
        }

        private void WireUp()
        {
            var container = new Container();
            FrameworkBootstrapper.WireUp(container, "DbConnection");
        }
    }
}
