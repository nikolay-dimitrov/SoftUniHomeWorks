using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a >= b && c < a)
            {
                if (b > c)
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", a, b, c);
                }
            }
            if(c >= b && a <= c)
            {
                if (b > a)
                {
                    Console.WriteLine("{0},{1},{2}", c, b, a);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", c, a, b);
                }
            }
            if(b > a && c < b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }
            }

        }
    }
}
