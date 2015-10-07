using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CategorizeNumbersAndFindMinMaxAverage
{
    class Problem3CategorizeNumbersAndFindMinMaxAverage
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            double[] floatNumber = numbers.Split().Select(double.Parse).ToArray();
            List<double> sumfloating = new List<double>();
            List<double> sumRound = new List<double>();
            for (int i = 0; i < floatNumber.Length; i++)
            {
                if (floatNumber[i] % 1 != 0)
                {
                    sumfloating.Add(floatNumber[i]); 
                }

                else
                {
                    sumRound.Add(floatNumber[i]); 
                }
            }

            Console.Write("[");
            foreach (var fP in sumfloating)
            {
                Console.Write(fP + " ");
            }
            Console.Write("] - > ");
            Console.Write("min:{0:f2}, ", sumfloating.Min());
            Console.Write("max:{0:f2}, ", sumfloating.Max());
            Console.Write("sum:{0:f2}, ", sumfloating.Sum());
            Console.WriteLine("avg:{0:f2}", sumfloating.Average());

            Console.Write("[");
            foreach (var round in sumRound)
            {
                Console.Write(round + " ");
            }
            Console.Write("] - > ");
            Console.Write("min:{0}, ", sumRound.Min());
            Console.Write("max:{0}, ", sumRound.Max());
            Console.Write("sum:{0}, ", sumRound.Sum());
            Console.WriteLine("avg:{0:f2}", sumRound.Average());
        }
    }
}
