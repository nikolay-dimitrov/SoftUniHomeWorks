using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a positon");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a bit value");
            int v = int.Parse(Console.ReadLine());
            if (v == 0)
            {
                int mask0 = ~(1 << p);
                int result0 = mask0 & number;

                Console.WriteLine(result0);
            }
            else if (v == 1)
            {
                int mask1 = (1 << p);
                int result1 = number | mask1;

                Console.WriteLine();
                Console.WriteLine(result1);
                Console.WriteLine();
                Console.WriteLine(Convert.ToString(result1, 2));
            }
        }
    }
}
