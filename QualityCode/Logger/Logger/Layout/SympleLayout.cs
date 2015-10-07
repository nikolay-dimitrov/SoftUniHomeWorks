using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Layout
{
    using global::Logger.Contracts;

    public class SympleLayout:ILayout
    {
        private const string LayoutFormat = "{0} - {1} - {2}";

        public string Fromat(string message, ReportLevel reportLevel, DateTime date)
        {
            return string.Format(LayoutFormat,date,reportLevel,message);
        }
    }
}
