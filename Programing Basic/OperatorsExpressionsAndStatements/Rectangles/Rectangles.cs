using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double w,h,per_rect,area_rect;
            Console.WriteLine("Enter the Width and Height : ");
            w = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            per_rect = 2 * (w + h);
            area_rect = w * h;
            Console.WriteLine("Perimeter of Rectangle : {0}", per_rect);
            Console.WriteLine("Area of Rectangle : {0}", area_rect);
            Console.Read();
        }
    }
}
