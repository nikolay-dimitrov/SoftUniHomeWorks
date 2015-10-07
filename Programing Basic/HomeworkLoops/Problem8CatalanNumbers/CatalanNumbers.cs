using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem8CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int N;
            BigInteger cathlanNumber = 1;
            Console.WriteLine("Enter N: ");
            N = int.Parse(Console.ReadLine());
            int lenght = 2 * N;
            int[] p = new int[lenght];
            int[] q = new int[lenght];

            for (int num = 2; num <= N; num++)
            {
                MakeInPrimes(num, q);
            }

            for (int num = N + 2; num <= 2 * N; num++)
            {
                MakeInPrimes(num, p);
            }

            for (int i = 0; i < lenght; i++)
            {
                for (int j = p[i] - q[i]; j > 0; j--)
                {
                    cathlanNumber = cathlanNumber * i;
                }
            }
            Console.WriteLine(cathlanNumber);
        }

        private static void MakeInPrimes(int num, int[] q)
        {
            bool prime = true;
            int divider = 2;
            int checkNumber = num;
            int maxDivider = (int)Math.Sqrt(num);
            while (divider <= maxDivider)
            {
                if (checkNumber % divider == 0)
                {
                    q[divider]++;
                    checkNumber = checkNumber / divider;
                    divider--;
                }
                divider++;
            }
            if (prime)
            {
                q[checkNumber]++;
            }
        }
    }
}
