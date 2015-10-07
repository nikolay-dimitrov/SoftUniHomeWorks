using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem3CountSubstringOccurrences
{
    class Problem3CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string searchWord = Console.ReadLine();
            int count = 0;
            string search;
            for (int i = 0; i < text.Length - searchWord.Length + 1; i++)
            {
                search = text.Substring(i, searchWord.Length);
                if (string.Equals(search, searchWord, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
