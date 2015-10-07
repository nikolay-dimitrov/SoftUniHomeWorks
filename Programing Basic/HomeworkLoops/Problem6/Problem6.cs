using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Problem6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (k <= 1 || k > n || n <= 1 || n >= 100 || k >= 100)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            int Nfactorial = 1;
            int Kfactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                Nfactorial *= i;
                if(i<=k)
                { 
                    Kfactorial *= i;
                }
            }

            Console.WriteLine("{0}", Nfactorial / Kfactorial);
            
        }
    }
}
