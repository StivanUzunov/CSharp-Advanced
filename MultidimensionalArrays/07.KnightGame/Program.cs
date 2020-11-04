using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int counter = 0;
            char[,] matrix = ReadMatrix(rows);
            while (true)
            {
                int maxAtackedKnights = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentAttackedKnights = GetCountAttackedKnight(matrix, row, col);
                            if (currentAttackedKnights > maxAtackedKnights)
                            {
                                maxAtackedKnights = currentAttackedKnights;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }
                if (maxAtackedKnights == 0)
                {
                    break;

                }
                matrix[maxRow, maxCol] = '0';
                counter++;

            }

            Console.WriteLine(counter);

        }
    
        private static char[,] ReadMatrix(int rows)
        {
            char[,] matrix = new char[rows, rows];
            for (int row = 0; row < rows; row++)
            {

                char[] rowValues = Console.ReadLine().ToArray();
                for (int col = 0; col < rows; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
        static bool IsValidCell(int currRow, int currCol, char[,] matrix)
        {
            if (currRow >= 0 && currRow < matrix.GetLength(0) && currCol >= 0 && currCol < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
        static int GetCountAttackedKnight(char[,] matrix, int row, int col)
        {
            int counter = 0;

            if (IsValidCell(row - 2, col - 1, matrix) && matrix[row - 2, col - 1] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row - 2, col + 1, matrix) && matrix[row - 2, col + 1] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row - 1, col - 2, matrix) && matrix[row - 1, col - 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row - 1, col + 2, matrix) && matrix[row - 1, col + 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 1, col + 2, matrix) && matrix[row + 1, col + 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 1, col - 2, matrix) && matrix[row + 1, col - 2] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 2, col + 1, matrix) && matrix[row + 2, col + 1] == 'K')
            {
                counter++;
            }
            if (IsValidCell(row + 2, col - 1, matrix) && matrix[row + 2, col - 1] == 'K')
            {
                counter++;
            }
            return counter;
        }
    }
}
