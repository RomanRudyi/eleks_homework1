using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5]
            {
                { 4, 5, 5, 5, -5 },
                { 1, 2, -3, 10, -4 },
                { 1, 4, 3, 4, -5 },
                { 13, 11, 11, 6, 3 },
                { 2, 9, 3, 8, 1 }
            };

            Console.WriteLine("Input data:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum in row with negative numbers");
            SumInRowNeg(matrix);

            ShowSaddlePoints(matrix);

            Console.Read();
        }

        #region Sum in row with negative numbers
        public static void SumInRowNeg(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                bool hasNegative = false;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                    }
                    sum += matrix[i, j];
                }
                if (hasNegative)
                {
                    Console.Write($"Sum int row {i + 1} = {sum}\n");
                }
            }
        }
        #endregion

        #region Saddle point
        public static void ShowSaddlePoints(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (IsMinInRow(matrix, i, j) && IsMaxInCol(matrix, i, j))
                    {
                        Console.WriteLine($"Saddle point: row = {i + 1}, column = {j + 1}");
                    }
                }
            }
        }

        private static bool IsMinInRow(int[,] matrix, int row, int col)
        {
            bool isMin = true;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (i == col)
                {
                    continue;
                }
                if (matrix[row, col] > matrix[row, i])
                {
                    isMin = false;
                }
            }
            return isMin;
        }

        private static bool IsMaxInCol(int[,] matrix, int row, int col)
        {
            bool isMax = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == row)
                {
                    continue;
                }
                if (matrix[row, col] < matrix[i, col])
                {
                    isMax = false;
                }
            }
            return isMax;
        }
        #endregion
    }
}
