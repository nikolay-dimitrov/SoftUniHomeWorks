using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Logger
{
    using global::Logger.Contracts;

    public class Logger:ILogger
    {
        public IList<IAppender> Appenders { get; private set; }

        public Logger(params IAppender [] appender)
        {
            this.Appenders = new List<IAppender>(appender);
        }
        public void Info(string message)
        {
            this.Log(message,ReportLevel.Info);
        }

        public void Warn(string message)
        {
            this.Log(message,ReportLevel.Warn);
        }

        public void Error(string message)
        {
            this.Log(message,ReportLevel.Error);
        }

        public void Critical(string message)
        {
            this.Log(message,ReportLevel.Critical);
        }

        public void Fatal(string message)
        {
            this.Log(message,ReportLevel.Fatal);
        }

        private void Log(string message,ReportLevel reportLevel)
        {
            var date = DateTime.Now;
            foreach (var appender in this.Appenders)
            {
                appender.Append(message,reportLevel,date);
            }
        }
    }
}
