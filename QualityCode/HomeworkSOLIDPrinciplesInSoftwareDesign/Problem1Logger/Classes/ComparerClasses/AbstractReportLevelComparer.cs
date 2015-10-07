using Problem1Logger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.ComparerClasses
{
    using Problem1Logger.Enums;

    public abstract class AbstractReportLevelComparer : IReportLevelComparer
    {
        public AbstractReportLevelComparer()
        {

        }

        protected abstract int ConvertReportLevelToInt(ReportLevel reportLevel);

        public int Compare(ReportLevel levelToCompare, ReportLevel minimumLevel)
        {
            int levelToCompareAsInt = this.ConvertReportLevelToInt(levelToCompare);
            int minimumLevelAsInt = this.ConvertReportLevelToInt(minimumLevel);

            if (levelToCompare > minimumLevel)
            {
                return 1;
            }
            else if (levelToCompare < minimumLevel)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
