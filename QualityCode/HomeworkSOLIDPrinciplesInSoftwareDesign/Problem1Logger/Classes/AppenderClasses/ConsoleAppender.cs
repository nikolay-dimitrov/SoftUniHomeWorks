using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.AppenderClasses
{
    using Problem1Logger.Interfaces;

    public class ConsoleAppender : AbstractAppender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {

        }

        protected override void WriteToOutput(string logMessage)
        {
            Console.WriteLine(logMessage);
        }
    }
}
