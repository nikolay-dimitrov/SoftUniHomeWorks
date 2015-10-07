using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Problem3Extract_Emails
{
    class Problem3Extract_Emails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patternMeil = @"(?<=\s|^)[a-z0-9]+[_.-]?[a-z0-9]*@[a-z]+\-?[a-z]+(\.[a-z]+)+\b";
            Regex regexMail = new Regex(patternMeil);
            MatchCollection matches = regexMail.Matches(text);
            foreach (Match name in matches)
            {
                Console.WriteLine(name.Groups[0]);
            }
        }
    }
}
