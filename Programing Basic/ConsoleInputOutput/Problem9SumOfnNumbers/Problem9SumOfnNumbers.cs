using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9SumOfnNumbers
{
    class Problem9SumOfnNumbers
    {
        static void Main(string[] args)
        {
            double  sum = 0;
            Console.WriteLine("How Many Times u wanna to add");
            double y = Convert.ToDouble(Console.ReadLine());
            for (double x = 1; x <= y; x++)
            {
                Console.WriteLine("Enter a number.");
                double i = Convert.ToDouble(Console.ReadLine());
                sum = sum + i;
            }
            Console.WriteLine("Total is=" + sum);
        }
    }
}
