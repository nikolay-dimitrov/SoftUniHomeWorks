using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Greater: {0}", (a + b + Math.Abs(a - b)) / 2);
            
        }
    }
}
