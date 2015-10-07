using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SumOf3Numbers
{
    class Problem1SumOf3Numbers
    {
        static void Main(string[] args)
        {
            double number1, number2, number3, sum;
            Console.WriteLine("Enter first number");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            number3 = Convert.ToDouble(Console.ReadLine());

            sum = number1 + number2 + number3;

            Console.WriteLine("Sum is {0}", sum);
        }

    }
}
