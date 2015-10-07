using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12RandomizeTheNumbers_1_N
{
    class RandomizeTheNumbers_1_N
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer n:");
            int n = int.Parse(Console.ReadLine());
            int[] theArray = new int[n];
            int i = 0;
            while (i < theArray.Length)
            {
                theArray[i] = ++i;
            }
            Random r = new Random();
            while (i > 1)
            {
                int j = r.Next(i);
                int t = theArray[--i];
                theArray[i] = theArray[j];
                theArray[j] = t;
            }
            for (i = 0; i < theArray.Length; ++i)
            {
                Console.WriteLine(theArray[i].ToString());
            }

        }
    }
}
