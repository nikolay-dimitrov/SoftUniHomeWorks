using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits_Exchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int numP, bit1, bit2, mask1, mask2;
            for (int i = 0; i < 3; i++)
            {
                numP = num >> (3 + i);
                bit1 = numP & 1;
                numP = num >> (24 + i);
                bit2 = numP & 1;
                bit1 = bit1 << (24 + i);
                bit2 = bit2 << (3 + i);
                mask1 = 1 << (3 + i);
                num = num & ~mask1;
                mask2 = 1 << (24 + i);
                num = num & ~mask2;
                num = num | bit1;
                num = num | bit2;
            }

            Console.WriteLine("Your new number is: {0}", num);
        }
    }
}
