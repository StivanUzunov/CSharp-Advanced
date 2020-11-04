using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = n[0];
            int cols = n[1];
            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            var queue = new Queue<char>(snake);


            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = queue.Dequeue();
                        queue.Enqueue(matrix[row, col]);
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    char[] currentRow = new char[cols];
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Dequeue();
                        queue.Enqueue(matrix[row, col]);
                        currentRow[col] = matrix[row, col];
                    }
                    string result = new string(currentRow);
                    Console.WriteLine(result);
                }


            }


        }
    }
}
