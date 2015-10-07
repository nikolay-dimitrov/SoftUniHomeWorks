using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            symbol = '\u002A';
            Console.WriteLine(symbol);
        }

        public static char symbol { get; set; }
    }
}
