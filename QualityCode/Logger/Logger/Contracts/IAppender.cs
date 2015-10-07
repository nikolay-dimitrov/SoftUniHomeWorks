using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Contracts
{
   public interface IAppender
   {
       ReportLevel Threshold { get; set; }

       ILayout Layout { get; set; }

       void Append(string message,ReportLevel reportLevel,DateTime date);
   }
}
