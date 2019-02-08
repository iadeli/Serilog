using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySerilog.Models
{
    public class Class1
    {
        public void Get()
        {
            Logger.Current.Information("This is a test");
        } 
    }
}