using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int p = 3;
            int nRightP = number >> p;
            int bit = nRightP & 1;
            Console.WriteLine(bit);
        }
    }
}
