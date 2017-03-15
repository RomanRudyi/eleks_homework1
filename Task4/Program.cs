using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 2, 2, 2, 2, 2, 2, 2 },
                { 1, 2, 3, 4, 2, 6, 7, 8 },
                { 1, 2, 3, 4, 2, 6, 7, 8 },
                { 1, 2, 2, 2, 2, 2, 2, 2 },
                { 1, 2, 3, 4, 2, 6, 7, 8 },
                { 1, 2, 3, 4, 2, 6, 7, 8 },
                { 1, 2, 3, 4, 2, 6, 7, 8 }
            };

            int[,] matrix4 = new int[,]
            {
                { 1, 1, 1, 1 },
                { 1, 2, 2, 2 },
                { 1, 2, 3, 4 },
                { 1, 2, 3, 4 }
            };

            Console.WriteLine("Row & col are equals");

            ShowEqualsRowAndCol(matrix);

            Console.Read();
        }

        public static void ShowEqualsRowAndCol(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool areEqual = true;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                        areEqual = false;
                }
                if (areEqual)
                    Console.WriteLine($"k = {i}");
            }
        }
    }
}
