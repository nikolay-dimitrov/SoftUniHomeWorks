using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("perimeter {0:F2}", 2 * Math.PI * radius);
            Console.WriteLine("area {0:F2}", Math.PI * Math.Pow(radius, 2));

        }
    }
}
