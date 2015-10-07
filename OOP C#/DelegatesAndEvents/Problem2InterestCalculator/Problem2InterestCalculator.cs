using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2InterestCalculator
{
    public static class InterestCalculatorExec
    {
        private const int InterestCompounded = 12;

        private class Problem2InterestCalculator
        {
            private static void Main(string[] args)
            {
                Func<decimal, decimal, int, decimal> simple = GetSimpleInterest;
            Func<decimal, decimal, int, decimal> compound = GetCompoundInterest;

            var acc1 = new InterestCalculator(500m, 5.6m, 10, compound);
            var acc2 = new InterestCalculator(2500m, 7.2m, 15, simple);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);
        }

        private static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + (interest / 100 * years));
        }

        private static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interest / 100 / InterestCompounded)), years * InterestCompounded);
        }
            }
        }
}
