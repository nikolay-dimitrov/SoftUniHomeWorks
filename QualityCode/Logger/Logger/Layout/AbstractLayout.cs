using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Logger;
using Logger.Contracts;

public abstract class AbstractLayout : ILayout
{

    public AbstractLayout()
    {

    }


    protected string ReportLevelAsString(ReportLevel reportLevel)
    {
        switch (reportLevel)
        {
            case ReportLevel.Info:
                {
                    return "Info";
                }
            case ReportLevel.Warn:
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

    public abstract string Fromat(string message, ReportLevel reportLevel, DateTime date);


}

