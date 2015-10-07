using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a positon");
            int p = int.Parse(Console.ReadLine());
            int nRightP = number >> p;
            int bit = nRightP & 1;
            if (bit == 1)
            Console.WriteLine("True");
            else
            Console.WriteLine("False");
        }
    }
}
