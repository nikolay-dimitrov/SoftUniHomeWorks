using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Flase");
            }
   
        }
    }
}
