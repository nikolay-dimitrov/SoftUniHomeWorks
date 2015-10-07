using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.LoggerClasses
{
    using Problem1Logger.Interfaces;

    public class Logger:AbstractLogger
    {
        public Logger(params IAppender[] appender)
            : base(appender)
        {

        }
    }
}
