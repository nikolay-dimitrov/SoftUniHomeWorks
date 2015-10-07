using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Interfaces
{
    public interface ILogger : IInfoLogger, IWarningLogger, IErrorLogger, ICriticalLogger, IFatalLogger
    {
        IAppender[] Appenders { get; }
        void AddAppender(IAppender appender);
    }
}
