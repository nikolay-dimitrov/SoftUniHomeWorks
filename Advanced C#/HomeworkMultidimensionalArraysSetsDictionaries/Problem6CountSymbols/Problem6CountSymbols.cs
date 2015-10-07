using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6CountSymbols
{
    class CharacterCount
    {
        public static SortedDictionary<char, ulong> Count(string stringToCount)
        {
            SortedDictionary<char, ulong> characterCount = new SortedDictionary<char, ulong>();

            foreach (var character in stringToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            return characterCount;
        }
        
        
        
        static void Main(string[] args)
        {
            string longText = Console.ReadLine();

            var count = CharacterCount.Count(longText);

            foreach (var character in count)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
    }
}
