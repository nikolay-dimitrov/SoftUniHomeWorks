using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6SubsetSums
{
    class Program
    {
        static int[] numbers;
        static int N;
        static bool solution = false;

        private static void PrintSubset(List<int> subset)
        {

            for (int i = 0; i < subset.Count; i++)
            {
                if (i < subset.Count - 1)
                {
                        Console.Write("{0} +", subset[i]);
                    }
                    else
                    {
                        Console.Write("{0} = {1}", subset[i], N);
                    }
                }
                Console.WriteLine();
            }

            private static int CalculateSum(List<int> subset)
            {
                int sum = 0;
              
                for (int i = 0; i < subset.Count; i++)
                    sum += subset[i];
                return sum; 
            }


        static void MakeSubset(int index, List<int> subset)
        {
            int sum = CalculateSum(subset);
            if (sum == N)
            {
                PrintSubset(subset);
                solution = true;
            }

            if (subset.Count == numbers.Length)
                return;

            for (int i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);

                MakeSubset(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }

            static void Main()
            {

                Console.Write("Please, enter a value for N: ");
                N = int.Parse(Console.ReadLine());


                Console.WriteLine("Please enter a sequence of numbers, separated by a space: ");
                numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine("\nOutput:");

                List<int> subset = new List<int>();
                MakeSubset(0, subset);

                if (!solution)
                    Console.WriteLine("No matching subsets.");
 
            }
    }
}