using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SequencesOfEqualStrings
{
    class Problem4SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string[] wordsToConpare = Console.ReadLine().Split();

            for (int i = 0; i < wordsToConpare.Length - 1; i++)
            {
                Console.Write(wordsToConpare[i] + " ");
                if (!wordsToConpare[i].Equals(wordsToConpare[i] + 1))
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(wordsToConpare[wordsToConpare.Length - 1]);
        }
    }
}
