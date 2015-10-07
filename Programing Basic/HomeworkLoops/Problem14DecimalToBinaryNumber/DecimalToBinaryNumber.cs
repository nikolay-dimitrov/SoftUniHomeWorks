using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long num;
            Console.Write("Enter a Number : ");
            num = long.Parse(Console.ReadLine());
            long quot;
            string rem = "";
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
            
        }
    }
}
