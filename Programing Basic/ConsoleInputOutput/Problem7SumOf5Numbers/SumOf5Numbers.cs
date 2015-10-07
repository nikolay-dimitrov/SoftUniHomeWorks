using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers in a position separated by a space:");
            string[] numbers = new string[5];
            double sum = 0;
            numbers = Console.ReadLine().Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
