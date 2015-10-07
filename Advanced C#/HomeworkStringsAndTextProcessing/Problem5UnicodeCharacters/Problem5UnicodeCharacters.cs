using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5UnicodeCharacters
{
    class Problem5UnicodeCharacters
    {
        
  

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string unicode = String.Empty;
            foreach (char i in input)
            {
                unicode += "\\u" + ((int)i).ToString("X4");
            }
            Console.WriteLine(unicode);

          
        }
    }
}
