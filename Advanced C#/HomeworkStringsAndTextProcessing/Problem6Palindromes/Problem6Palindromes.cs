using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem6Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            var result = Regex.Matches(words, @"\w+").Cast<Match>()
                        .Select(m => m.Value)
                        .Where(w => String.Join("", w.Reverse()) == w).ToList();
            Console.WriteLine(string.Join(", ", result));  
        }
    }
}
