using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a positon");
            int p = int.Parse(Console.ReadLine());
            int nRightP = number >> p;
            int bit = nRightP & 1;
            Console.WriteLine("Bit Index : {0}" , bit);
        }
    }
}
