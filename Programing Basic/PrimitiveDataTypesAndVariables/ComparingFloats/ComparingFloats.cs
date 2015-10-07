using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareFloatingPoingNumbers
{
    class CompareFloat
    {
        static void Main(string[] args)
        {

            double firstValue = -4.999999;
            double secondValue = -4.999998;
            bool nearlyEqual = Math.Abs(firstValue - secondValue) < 0.000001;
            Console.WriteLine("The numbers are nearly equal: {0}", nearlyEqual);
        }

    }
}

