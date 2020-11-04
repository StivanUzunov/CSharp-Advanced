using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = n[0];
            int col = n[1];
            int[,] matrix = ReadMatrix(row, col);
            int maxSum = 0;
            int[,] maxRowColPrint = new int[3, 3];
            for (int rows = 0; rows <= row - 3; rows++)
            {
                for (int cols = 0; cols <= col - 3; cols++)
                {
                    int temporarySum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                        matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] +
                        matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                    if (temporarySum > maxSum)
                    {
                        maxSum = temporarySum;
                        int[,] maxRowCol = new int[3, 3] 
                        { {matrix[rows, cols], matrix[rows, cols + 1], matrix[rows, cols + 2] },
                        { matrix[rows + 1, cols]  ,  matrix[rows + 1, cols + 1]  ,  matrix[rows + 1, cols + 2] },
                        {  matrix[rows + 2, cols], matrix[rows + 2, cols + 1]  ,  matrix[rows + 2, cols + 2] }
                        };
                        maxRowColPrint = maxRowCol;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int rows = 0; rows <maxRowColPrint.GetLength(0); rows++)

            {

                for (int cols = 0; cols < maxRowColPrint.GetLength(1); cols++)

                {

                    Console.Write(maxRowColPrint[rows, cols]);
                    Console.Write(' ');

                }

                Console.WriteLine();

            }
        }





        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {

                int[] rowValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
    }
}
