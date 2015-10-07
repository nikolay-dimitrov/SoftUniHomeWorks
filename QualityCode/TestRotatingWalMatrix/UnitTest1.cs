using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RotatingWalkInMatrix.Tests
{
    [TestClass]
    public class RotatingWalkInMatrixTest
    {
        [TestMethod]
        public void TestSmallestPossibleMatrix()
        {
            int[,] matrix = new int[1, 1];
            RotatingWalkInMatrix.RotateWalkInMatrix(matrix);
            int[,] expected = new int[,] { { 1 } };
            AssertMatrixEquality(matrix, expected);
        }

        [TestMethod]
        public void TestSampleMatrix()
        {
            int[,] matrix = new int[6, 6];
            RotatingWalkInMatrix.RotateWalkInMatrix(matrix);
            int[,] expected = new int[,]
            { 
                {1, 16, 17, 18, 19, 20},
                {15, 2, 27, 28, 29, 21},
                {14, 31, 3, 26, 30, 22},
                {13, 36, 32, 4, 25, 23},
                {12, 35, 34, 33, 5, 24},
                {11, 10, 9, 8, 7, 6},
            };
            AssertMatrixEquality(matrix, expected);
        }

        private void AssertMatrixEquality(int[,] matrix1, int[,] matrix2)
        {
            Assert.AreEqual(matrix1.GetLength(0), matrix2.GetLength(0), "Matrix dimensions are not the same!");
            Assert.AreEqual(matrix1.GetLength(1), matrix2.GetLength(1), "Matrix dimensions are not the same!");

            for (int row = 0; row < matrix1.GetLength(0); row++)
            {
                for (int col = 0; col < matrix1.GetLength(1); col++)
                {
                    Assert.AreEqual(matrix1[row, col], matrix2[row, col], "Matrix values are not the same!");
                }
            }
        }
    }
}