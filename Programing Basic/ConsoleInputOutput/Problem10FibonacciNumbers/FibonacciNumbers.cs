using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n, first = 0, second = 1, third = 0;
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("First {0} Fibonacci numbers {1} {2} ", n, first, second);
            for (int i = 3; i <= n; i++)
            {
                third = first + second;
                Console.Write("{0} ", third);
                first = second;
                second = third;
            }
            Console.ReadLine();
        }
    }
}