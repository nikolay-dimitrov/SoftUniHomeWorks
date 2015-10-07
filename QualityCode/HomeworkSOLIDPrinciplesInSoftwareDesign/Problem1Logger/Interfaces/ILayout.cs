using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Interfaces
{
    using Problem1Logger.Enums;

    public interface ILayout
    {
        string FormatLogString(ReportLevel reportLevel, string message);
    }
}
