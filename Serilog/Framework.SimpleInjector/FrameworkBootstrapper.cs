using Framework.Core.CustomSerilog;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.SimpleInjector
{
    public class FrameworkBootstrapper
    {
        public static void WireUp(Container container, string connectionStringKey)
        {
            SetupLogger(container, connectionStringKey);
        }

        private static void SetupLogger(Container container, string connectionStringKey)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringKey].ConnectionString;
            var adapter = new SerilogAdapter(SeriLogFactory.Create(connectionString));
            container.Register<Core.ILogger>(() => adapter, Lifestyle.Singleton);
            Core.Logger.SetCurrent(adapter);
        }
    }
}
