using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.LayoutClasses
{
    using Problem1Logger.Enums;

    public class SimpleLayout:AbstractLayout

    {
       public SimpleLayout()
        {

        }

        public override string FormatLogString(ReportLevel reportLevel, string logMessage)
        {
            string logString = string.Format(
                "{0} - {1} - {2}",
                DateTime.Now,
                this.ReportLevelAsString(reportLevel),
                logMessage);

            return logString;
        }
    }
}
