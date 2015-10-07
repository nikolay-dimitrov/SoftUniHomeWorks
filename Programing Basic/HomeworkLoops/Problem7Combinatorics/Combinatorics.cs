using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Combinatorics
{
    class Combinatorics
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            decimal result = 1;
            if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            for (int i = 1; i <= k; i++)
            {
                result *= n - (k - i);
                result /= i;
            }
            Console.WriteLine("{0}", result);
        }
    }
}
