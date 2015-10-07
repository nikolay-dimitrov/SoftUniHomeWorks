using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please Enter b ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please Enter h ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine(((a + b) / 2) * h);
        }
    }
}
