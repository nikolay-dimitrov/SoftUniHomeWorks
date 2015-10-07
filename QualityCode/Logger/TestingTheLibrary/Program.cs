using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTheLibrary
{
    using Logger;
    using Logger.Appenders;
    using Logger.Contracts;
    using Logger.Layout;
    using Logger.Logger;

    class Program
    {
        static void Main(string[] args)
        {
            ILayout simpleLayout = new SympleLayout();
            IAppender consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.Threshold = ReportLevel.Error;
            ILogger logger = new Logger(consoleAppender);

            logger.Error("Error");
            logger.Critical("Windows failed.");
            logger.Info("Info");

            foreach (IAppender appender in logger.Appenders)
            {
                appender.Layout = new XmlLayout();
            }

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");
        }
    }
}
