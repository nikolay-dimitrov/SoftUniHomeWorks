using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1BiggerNumber
{
    class Problem1BiggerNumber
    {
       
        static  int GetMax(int firstNumber, int secondNumber)
        {
            int result = Math.Max(firstNumber, secondNumber);
            return result;
        }

        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);

        }
    }
}
