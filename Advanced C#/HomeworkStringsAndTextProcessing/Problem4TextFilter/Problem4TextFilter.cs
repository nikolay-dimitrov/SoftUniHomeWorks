using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4TextFilter
{
    class Problem4TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                text =text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
