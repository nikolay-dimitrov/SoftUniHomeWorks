using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.LayoutClasses
{
    using System.Configuration;

    using Problem1Logger.Enums;
    using Problem1Logger.Interfaces;

   public abstract class AbstractLayout: ILayout
    {

        public AbstractLayout()
        {

        }

        public abstract string FormatLogString(ReportLevel reportLevel, string logMessage);

        protected string ReportLevelAsString(ReportLevel reportLevel)
        {
            switch (reportLevel)
            {
                case ReportLevel.Info:
                    {
                        return "Info";
                    }
                case ReportLevel.Warning:
                    {
                        return "Warning";
                    }
                case ReportLevel.Error:
                    {
                        return "Error";
                    }
                case ReportLevel.Critical:
                    {
                        return "Critical";
                    }
                case ReportLevel.Fatal:
                    {
                        return "Fatal";
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Unrecognised Report Level");
                    }
            }
        }


    }
}
