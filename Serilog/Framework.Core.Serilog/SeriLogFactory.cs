﻿using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.CustomSerilog
{
    public static class SeriLogFactory
    {
        public static Serilog.ILogger Create(string connectionString)
        {
            var logDB = connectionString; //System.Configuration.ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            var logTable = "Logs";

            //var columnOptions = new ColumnOptions()
            //{
            //    AdditionalDataColumns = new Collection<DataColumn>
            //    {
            //        new DataColumn {
            //            DataType = typeof (int),
            //            ColumnName = "EventId",
            //            AllowDBNull = true
            //        }
            //    }
            //};

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
                    //columnOptions: columnOptions
                ).CreateLogger();

            return log;
        }
    }
}
