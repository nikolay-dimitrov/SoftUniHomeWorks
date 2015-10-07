using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1FillTheMatrix
{
    class Problem1FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("In which way would you want to fill the matrix (a, b): ");
            char choise = char.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            switch (choise)
            {
                case 'a':FillMatrixA(matrix); break;
                case 'b':FillMatrixB(matrix); break;
                    
            }
            PrintingMatrix(matrix);
        }

        private static void FillMatrixB(int[,] matrix)
        {
            bool isDirDown = true;
            for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
            {
                while (row>=0 &&row <matrix.GetLength(0))
                {
                    matrix[row, col] = index++;
                    row += isDirDown ? +1 : -1;
                }
                isDirDown = !isDirDown;
                row += isDirDown ? +1 : -1;
            }
        }

        private static void FillMatrixA(int[,] matrix)
        {
            for (int col = 0, index = 1; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++, index++)
                {
                    matrix[row, col] = index;
                }
            }
        }
        private static void PrintingMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
