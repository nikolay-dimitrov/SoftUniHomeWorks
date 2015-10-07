using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4SentenceExtractor
{
    class Problem4SentenceExtractor
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", word);
            Regex regexSentence = new Regex(pattern);
            MatchCollection matches = regexSentence.Matches(text);
            foreach (Match sentence in matches)
            {
                Console.WriteLine(sentence.Groups[0]);
            }
        }
    }
}
