using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.LayoutClasses
{
    using Problem1Logger.Enums;

    public class XmlLayout : AbstractLayout
    {
        public XmlLayout()
        {
            
        }

        public override string FormatLogString(ReportLevel reportLevel, string logMessage)
        {
            string logString = string.Format(
                "<log>\r\n" +
                "\t<date>{0}</date>{1}" +
                "\t<level>{2}</level>{1}" +
                "\t<message>{3}</message>\n" +
                "</log>",
                DateTime.Now,
                Environment.NewLine,
                this.ReportLevelAsString(reportLevel),
                logMessage
                );

            return logString;
        }
    }
}
