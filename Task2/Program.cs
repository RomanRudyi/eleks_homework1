using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][]
            {
                new int[]{ 1, -2, 3, 1, 1 },
                new int[]{ 1, 2, -3, 1, 4 },
                new int[]{ 1, 2, 3, 4, 5 },
                new int[]{ 1, 1, -1, 2, 3 },
                new int[]{ 1, 2, 3, 4, 1 }
            };

            int idx = GetFirstPositiveRowIndex(matrix);

            Console.WriteLine($"First row without negative numbers is {idx}");

            Console.WriteLine($"Rows were rearranged by count of duplicates\n");
            RearrangeByDuplicates(matrix, 1);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]}\t");
                }
                Console.Write("\n");
            }

            Console.Read();
        }

        #region Index of the first row without negative numbers
        public static int GetFirstPositiveRowIndex(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                bool hasNegative = false;
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] < 0)
                    {
                        hasNegative = true;
                        continue;
                    }
                }
                if (hasNegative == false)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Rearranging rows by count of duplicates
        public static void RearrangeByDuplicates(int[][] matrix, int duplicate)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int[] X = matrix[i];
                int j = i;
                int countDupX = GetCountOfDuplicatesInRow(X, duplicate);
                while (j > 0 && countDupX < GetCountOfDuplicatesInRow(matrix[j - 1], duplicate))
                {
                    matrix[j] = matrix[j - 1];
                    j--;
                }
                matrix[j] = X;
            }
        }

        private static int GetCountOfDuplicatesInRow(int[] row, int duplicate)
        {
            int count = 0;
            foreach (int i in row)
                if (i == duplicate)
                    count++;
            return count;
        }
        #endregion
    }
}
