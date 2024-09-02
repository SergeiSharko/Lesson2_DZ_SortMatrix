using System;
using System.Linq;

namespace SortMatrix

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            PrintMatrix(a, "Source Matrix:");
            var arr = ConvertMatrixToArray(a);
            Array.Sort(arr);
            ConvertArrayToMatrix(arr, a);         
            Console.WriteLine();
            PrintMatrix(a, "Sorted Matrix:");
            Console.ReadKey();

        }


        static void PrintMatrix(int[,] myMatrix, string text)
        {
            Console.WriteLine($"{text}");
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.Write($"{myMatrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }

        static int[] ConvertMatrixToArray(int[,] myMatrix)
        {
            int[] array = new int[myMatrix.GetLength(0) * myMatrix.GetLength(1)];
            return array = myMatrix.Cast<int>().ToArray();
        }

        static void ConvertArrayToMatrix(int[] array, int[,] matrix)
        {
            int z = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[z];
                    z++;
                }
            }
        }
    }
}
