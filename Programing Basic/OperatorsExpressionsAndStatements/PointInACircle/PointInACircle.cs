using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Please Enter x coordinate of the point : ");
            float x = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please Enter y coordinate of the point : ");
            float y = Convert.ToSingle(Console.ReadLine());
            bool check = (x - 1) * (x - 1) + (y - 1)* (y - 1) <= 1.5 * 1.5;
            bool outOfRectangle = (-1 > x || x > 5 && -1 > y || y > 1);
            if(check == true && outOfRectangle == true) 
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}