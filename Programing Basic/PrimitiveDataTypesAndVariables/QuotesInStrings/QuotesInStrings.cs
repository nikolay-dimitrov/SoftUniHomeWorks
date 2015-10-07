using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string string2 = "The \"use\" of quotations causes difficulties";
            string string1 = @"The ""use"" of quotations causes difficulties";
            Console.WriteLine("{0}\n{1}", string1, string2);
        }
    }
}
