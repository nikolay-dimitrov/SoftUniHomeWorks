using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LastDigitOfNumber
{
    class Problem2LastDigitOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            string word = GetLastDigitAsWord(number);
            Console.WriteLine(word);
        }
        static string GetLastDigitAsWord(int number)
        {
            int lastDigit = number % 10;
            string word = "";
            switch (lastDigit)
            {
                case 0: word = "zero"; break;
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
                case 10: word = "ten"; break;
                default:
                    break;
            }
            return word;
        }
    }
}

