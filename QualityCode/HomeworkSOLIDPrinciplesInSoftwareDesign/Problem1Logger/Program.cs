using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger
{
    using Problem1Logger.Classes.AppenderClasses;
    using Problem1Logger.Classes.LayoutClasses;
    using Problem1Logger.Classes.LoggerClasses;
    using Problem1Logger.Interfaces;

    class Program
    {
        static void Main(string[] args)
        {
            ILayout simLayout = new SimpleLayout();
            IAppender conAppender = new ConsoleAppender(simLayout);
            ILogger logger = new Logger(conAppender);

            logger.Error("Error parsing JSON");
            logger.Info(string.Format("User {0} successfully registered.", "Pesho"));

            Console.WriteLine(new string('-',20));

            IFileAppender fileAppender = new FileAppender(simLayout);
            fileAppender.File = "log.txt";

            logger.AddAppender(fileAppender);

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");

            Console.WriteLine(new string('-',20));

            foreach (IAppender appender in logger.Appenders)
            {
                appender.Layout = new XmlLayout();
            }

            logger.Fatal("mscorlib.dll does not respond");
            logger.Critical("No connection string found in App.config");

            Console.WriteLine(new string('-', 20));

            foreach (IAppender appender in logger.Appenders)
            {
                appender.ReportLevelMinimum = Enums.ReportLevel.Error;
            }

            logger.Info("Everything seems fine");
            logger.Warning("Warning: ping is too high - disconnect imminent");
            logger.Error("Error parsing request");
            logger.Critical("No connection string found in App.config");
            logger.Fatal("mscorlib.dll does not respond");

            Console.WriteLine(new string('-', 20));
        }
    }
}
