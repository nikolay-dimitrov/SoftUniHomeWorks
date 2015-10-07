using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Logger.Classes.ValidatorClasses
{
   public static class DataValidator
    {
       public static void ValidateMessageString(string logMessage, string exceptionMessage)
        {
            if (string.IsNullOrEmpty(logMessage))
            {
                throw new ArgumentNullException(exceptionMessage);
            }
        }

       public static void CheckThatFilePathIsSet(string filePath, string exceptionMessage)
       {
           if (filePath == null)
           {
               throw new ArgumentNullException(exceptionMessage);
           }
       }
    }
}
