using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideACircleAndOutsideofARectangle
{
    class PointInsideACircleAndOutsideofARectangle
    {
        static void Main(string[] args)
        {

            Console.Write("Please Enter x coordinate of the point : ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please Enter y coordinate of the point : ");
            float y = Convert.ToSingle(Console.ReadLine());
            float check = x * x + y * y;
            if (check <= 1.5)

                Console.WriteLine("True");

            else
                Console.WriteLine("False");
        }
    }
}
