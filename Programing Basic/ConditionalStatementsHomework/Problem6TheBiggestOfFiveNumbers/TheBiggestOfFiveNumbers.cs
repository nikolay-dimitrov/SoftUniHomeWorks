using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Type number 1:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Type number 2:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Type number 3:");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Type number 4:");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Type number 5:");
            double e = double.Parse(Console.ReadLine());
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;

            Console.WriteLine("The bigger number is " + max);

        }
    }
}
