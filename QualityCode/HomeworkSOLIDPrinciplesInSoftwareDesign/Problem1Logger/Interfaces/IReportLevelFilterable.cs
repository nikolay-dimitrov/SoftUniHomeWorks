using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Interfaces
{
    using Problem1Logger.Enums;

    public interface IReportLevelFilterable
    {
        ReportLevel ReportLevelMinimum { get; set; }
        IReportLevelComparer ReportLevelComparer { get; set; }
        bool ShouldPrint(ReportLevel reportLevel);
    }
}
