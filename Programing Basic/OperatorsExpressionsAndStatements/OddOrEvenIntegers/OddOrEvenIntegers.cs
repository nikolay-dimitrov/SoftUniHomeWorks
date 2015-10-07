using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("false");
                Console.Read();
            }
            else
            {
                Console.Write("true");
                Console.Read();
            }
        }
    }
}
