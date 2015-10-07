using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int positionX = 0;
            int positionY = 0;
            int direction = 0;
            int stepsCount = n - 1;
            int stepPosition = 0;
            int stepChange = n%2==0? n - 1: n;

            for (int i = 1; i <= n * n; i++)

            {
                matrix[positionY, positionX] = i;
                if (stepPosition < stepsCount)
                {
                stepPosition++;
                }
                else
                {
                stepPosition = 1;
                    if (stepChange == 1)
                    {
                         stepsCount--;
                    }
                stepChange = (stepChange + 1)%2;
                direction = (direction+1)%4;

            }

                switch (direction)
                {
                        case 0:
                        positionX++;
                        break;
                        case 1:
                        positionY++;
                        break;
                        case 2:
                        positionX--;
                        break;
                        case 3:
                        positionY--;
                        break;
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)

            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0, 4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
