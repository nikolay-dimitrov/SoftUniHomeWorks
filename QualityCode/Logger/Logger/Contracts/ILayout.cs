using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Contracts
{
   public interface ILayout
   {
       string Fromat(string message,ReportLevel reportLevel,DateTime date);
   }
}
