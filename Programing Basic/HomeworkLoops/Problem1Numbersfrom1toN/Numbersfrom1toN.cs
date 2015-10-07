using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Numbersfrom1toN
{
    class Numbersfrom1toN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
