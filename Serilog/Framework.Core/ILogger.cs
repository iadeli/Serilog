using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
    public interface ILogger
    {
        void Debug(string template, params object[] parameters);
        void Information(string template, params object[] parameters);
        void Warn(string template, params object[] parameters);
        void Error(Exception ex);
    }
}
