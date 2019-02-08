using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilog
{
    class Program
    {
        static void Main(string[] args)
        {
            SerilogContext context = new SerilogContext();
            var logDB = System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var logTable = "Logs";
            //var options = new ColumnOptions();
            //options.Store.Remove(StandardColumn.Properties);
            //options.Store.Add(StandardColumn.LogEvent);
            //options.LogEvent.DataLength = 2048;
            //options.PrimaryKey = options.TimeStamp;
            //options.TimeStamp.NonClusteredIndex = true;

            var log = new LoggerConfiguration()
                .WriteTo.MSSqlServer(
                    connectionString: logDB,
                    tableName: logTable//,
                                       //columnOptions: opts
                ).CreateLogger();

            log.Information("This is a Test");
        }
    }
}
