using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem1SeriesOfLetters
{
    class Problem1SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(\w)\1+");
            string replacement = "$1$1";
            string res = regex.Replace(input, replacement);
            replacement = "$1";
            res = regex.Replace(input, replacement);
            Console.WriteLine(res);
        }
    }
}
