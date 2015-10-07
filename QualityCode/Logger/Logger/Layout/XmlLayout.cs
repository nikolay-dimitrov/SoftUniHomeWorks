using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Layout
{
    public class XmlLayout : AbstractLayout
    {
        public XmlLayout()
        {

        }

        public override string Fromat(string message, ReportLevel reportLevel, DateTime date)
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
                message);

            return logString;
        }
    }
}
