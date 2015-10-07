using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Appenders
{
    using global::Logger.Contracts;

    public class ConsoleAppender:Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string message, ReportLevel reportLevel, DateTime date)
        {
            if (this.Threshold <=reportLevel)
            {
                var formateedMessage = this.Layout.Fromat(message, reportLevel, date);
                Console.WriteLine(formateedMessage);
            }
            
        }
    }
}
