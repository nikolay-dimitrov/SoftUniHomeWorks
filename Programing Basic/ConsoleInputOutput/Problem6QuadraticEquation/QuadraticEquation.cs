using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            bool isA, isB, isC;
            float a, b, c;
            Console.Write("Please enter number a ");
            isA = float.TryParse(Console.ReadLine(), out a);
            Console.Write("Please enter number b ");
            isB = float.TryParse(Console.ReadLine(), out b);
            Console.Write("Please enter number c ");
            isC = float.TryParse(Console.ReadLine(), out c);
            if (isA && isB && isC)
            { 
                float D = b * b - 4 * a * c;
                if (a == 0 && b == 0 && c == 0)
                {
                    Console.WriteLine("The number of real roots is infinity");
                }
                else if (a == 0 && b == 0 && c != 0)
                {
                    Console.WriteLine("There are no any real roots");
                }
                else if (a == 0 && b != 0)
                {
                    float x1 = -(c / b);
                    Console.WriteLine("The equation is linear. The real root is: {0}", x1);
                }
                else if (D == 0)
                {
                    float x1 = (float)(-b / (2 * a));
                    Console.WriteLine("There is only one root: {0}", x1);
                }
                else if (D < 0)
                {
                    Console.WriteLine("There are no real roots!");
                }
                else if (D > 0)
                {
                    float x1 = (float)((-b - Math.Sqrt(D)) / (2 * a));
                    float x2 = (float)((-b + Math.Sqrt(D)) / (2 * a));
                    Console.WriteLine("The real roots are: {0} and {1}", x1, x2);
                }
                else
                {
                    Console.WriteLine("There are no any real roots");
                }
            }
                else
            {
                Console.WriteLine("Enter numbers, not digits ot symbols!");
            }
        }
    }
}
