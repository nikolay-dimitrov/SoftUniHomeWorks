using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5SortingNumbers
{
    class Problem5SortingNumbers
    {
        static void Main(string[] args)
        {
            BubbleSort();

        }

        static int BubbleSort()
        {
            Console.Write("\n\nEnter the total number of elements: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] numarray = new int[max];

            for (int i = 0; i < max; i++)
            {
                Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }

           

            for (int i = 1; i < max; i++)
            {
                for (int j = 0; j < max - i; j++)
                {
                    if (numarray[j] > numarray[j + 1])
                    {
                        int temp = numarray[j];
                        numarray[j] = numarray[j + 1];
                        numarray[j + 1] = temp;
                    }
                }
                
            }

            Console.Write("\n\nThe numbers in ascending orders are given below:\n\n");
            for (int i = 0; i < max; i++)
            {
                Console.Write("Sorted [" + (i + 1).ToString() + "] element: ");
                Console.Write(numarray[i]);
                Console.Write("\n");
            }
            return 0;
        }

        
    }
}