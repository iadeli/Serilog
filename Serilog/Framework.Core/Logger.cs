using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public static class Logger
    {
        public static ILogger Current { get; private set; }
        public static void SetCurrent(ILogger logger)
        {
            Current = logger;
        }
    }
}
