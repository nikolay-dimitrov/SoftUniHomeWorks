using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0} and b = {1}", a, b);
            a = a + b; // a * b
            b = a - b; // a / b
            a = a - b; // a / b
            Console.WriteLine("a = {0} and b = {1}", a, b);
        }
    }
}
