using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? number1 = null;
            double? number2 = null;
            Console.WriteLine("{0};{1}", number1, number2);
 
            number1 = number1 + null;
            number2 = number2 + null;
 
            Console.WriteLine("{0};{1}", number1, number2);
 
            number1 = number1 + 230;
            number2 = number2 + 230.8;
 
            Console.WriteLine("{0};{1}", number1, number2);

            number1 = number1 + 100;
            number2 = number2 + 100.5;

            Console.WriteLine("{0};{1}", number1.GetValueOrDefault(), number2.GetValueOrDefault());
 
            
        }

        }
    }

