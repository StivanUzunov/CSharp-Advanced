using System;
using System.Linq;

namespace _02.SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n =Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = n[0];
            int col = n[1];
            char[,] matrix = ReadMatrix(row,col);
            int counter = 0;
            for (int rows = 0; rows <= row-2; rows++)
            {
                for (int cols = 0; cols <= col-2; cols++)
                {
                    if (matrix[rows,cols]==matrix[rows, cols+1] && matrix[rows, cols]==matrix[rows+1, cols]&& matrix[rows, cols]== matrix[rows+1, cols+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
               
                char[] rowValues = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
    }
}
