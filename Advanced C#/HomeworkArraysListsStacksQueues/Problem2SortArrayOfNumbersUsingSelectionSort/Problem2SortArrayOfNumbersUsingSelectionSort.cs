using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2SortArrayOfNumbersUsingSelectionSort
{
    class Problem2SortArrayOfNumbersUsingSelectionSort
    {
        static void Main(string[] args)
        {
           
            string numbers = Console.ReadLine();
            string[] arrNumbers = numbers.Split(' ');
            int[] arrInts = new int[arrNumbers.Length];
                for (int i = 0; i < arrNumbers.Length; i++)
                {
                    arrInts[i] = int.Parse(arrNumbers[i]);
                }
                for (int a = 0; a < arrInts.Length - 1; a++)
                {
                    int minValue = a;
                    for (int b = a + 1; b < arrInts.Length; b++)
                    {
                        if (arrInts[b] < arrInts[minValue])
                        {
                            minValue = b;
                        }
                    }
                    int temp = arrInts[a];
                    arrInts[a] = arrInts[minValue];
                    arrInts[minValue] = temp;
                           
                 }
                Console.WriteLine(string.Join(" ",arrInts));
        }
    }
}
