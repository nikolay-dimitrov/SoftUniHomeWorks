using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string string1 = "Hello";
            string string2 = "World";
            object concatenatedString = string1 + " " + string2;
            string newString = (string)concatenatedString;
            Console.WriteLine(newString);

        }
    }
}
