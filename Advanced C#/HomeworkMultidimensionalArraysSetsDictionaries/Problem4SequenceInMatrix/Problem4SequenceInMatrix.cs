using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4SequenceInMatrix
{
    class Problem4SequenceInMatrix
    {
        

            static readonly int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };
            static void Main()
            {
                Console.Write("Number of rows = ");
                int N = int.Parse(Console.ReadLine());
                Console.Write("Number of columns = ");
                int M = int.Parse(Console.ReadLine());
                Console.WriteLine();

                string[,] matrix = new string[N, M];
                for (int row = 0; row < N; row++)
                {
                    for (int col = 0; col < M; col++)
                    {
                        Console.Write("matrix[{0},{1}] = ", row, col);
                        string element = Console.ReadLine();
                        matrix[row, col] = element;
                    }
                }

                int bestLength = 0;
                string bestElement = string.Empty;

                PrintMatrix(matrix);
                FindLongestSequence(matrix, ref bestElement, ref bestLength);
                PrintResult(bestElement, bestLength);
            }

	        static void FindLongestSequence(string[,] matrix, ref string bestElement, ref int bestLength)
	        {
		            for (int row = 0; row < matrix.GetLongLength(0); row++)
		            {
			            for (int col = 0; col < matrix.GetLongLength(1); col++)
			            {
				            int direction = -1;

				            while (++direction < 4)
				            {
					            int currRow = row + directions[direction, 0];
					            int currCol = col + directions[direction, 1];
					            int currentLength = 1;

					            while (IsTraversable(matrix, row, col, currRow, currCol))
					            {
						            currentLength++;

						            if (currentLength > bestLength)
						            {
							            bestLength = currentLength;
							            bestElement = matrix[row, col];
						            }

						            currRow += directions[direction, 0];
						            currCol += directions[direction, 1];
					            }
				            }
			            }
		            }
	          }

	        static bool IsTraversable(string[,] matrix, int row, int col, int currRow, int currCol)
	        {
		        return currRow >= 0 && currRow < matrix.GetLongLength(0) &&
			           currCol >= 0 && currCol < matrix.GetLongLength(1) &&
			           matrix[currRow, currCol] == matrix[row, col];
	        }

	        static void PrintMatrix(string[,] matrix)
	        {
		        Console.WriteLine("\nMatrix:\n");
		        for (int row = 0; row < matrix.GetLongLength(0); row++)
		        {
			        for (int col = 0; col < matrix.GetLongLength(1); col++)
			        {
				        Console.Write(matrix[row, col] + "\t");
			        }
			        Console.WriteLine();
		        }
	        }

	        static void PrintResult(string bestElement, int bestLength)
	        {
		        Console.WriteLine("\nResult -> {0}({1} times)\n",
			        String.Concat(Enumerable.Repeat(bestElement + " ", bestLength)), bestLength);
	        }
    }
}


       
  
