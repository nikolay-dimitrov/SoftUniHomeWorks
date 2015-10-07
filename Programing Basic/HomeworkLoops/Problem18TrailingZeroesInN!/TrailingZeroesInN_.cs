using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem18TrailingZeroesInN_
{
    class TrailingZeroesInN_
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
                Console.WriteLine("{0}! {1}", i, factorial);
            }

            string s = factorial.ToString();
            char[] ch = s.ToCharArray();
            Array.Reverse(ch);
            Console.Write("{0}! reversed: ", N);
            Console.WriteLine(ch);
            int trailingZeros = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '0')
                {
                    trailingZeros++;
                }
                else break;
            }
            Console.WriteLine("Trailing Zeros = {0}", trailingZeros);
        }
    }
}
