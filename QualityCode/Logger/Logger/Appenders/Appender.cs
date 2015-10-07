using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Appenders
{
    using global::Logger.Contracts;

    public abstract class Appender:IAppender
    {
       protected Appender(ILayout layout)
       {
           this.Layout = layout;
       }

        public ReportLevel Threshold { get; set; }

        public ILayout Layout { get; set; }

        public abstract void Append(string message, ReportLevel reportLevel, DateTime date);

    }
}
