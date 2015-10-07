using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integer a and b:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int quotient = 0;
            int remainder = 1;
            while (remainder != 0)
            {
                remainder = a % b;
                quotient = a / b;
                a = b;
                b = remainder;
            }
            Console.WriteLine(a);
        }
    }
}
