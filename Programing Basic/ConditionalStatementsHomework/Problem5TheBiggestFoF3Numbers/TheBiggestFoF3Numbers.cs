using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5TheBiggestFoF3Numbers
{
    class TheBiggestFoF3Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the thurd number");
            double thurd = double.Parse(Console.ReadLine());
            double result;
            if (first > second)
            {
                result = first;
                if (first > thurd)
                    result = first;
                else
                    result = thurd;
            }
            else
            {
                result = second;
                if (second > thurd)
                    result = second;
                else
                    result = thurd;
            }
            Console.WriteLine("The bigger number is {0}", result);
        }
    }
}
