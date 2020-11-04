using System;
using System.Linq;

namespace _04._4._MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = n[0];
            int col = n[1];
            string[,] matrix = ReadMatrix(row, col);
            string command = "";
            while (command!="END")
            {
                command = Console.ReadLine();
                if (command=="END")
                {
                    break;
                }
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandOFInput = input[0];
                if (commandOFInput=="swap" && input.Length == 5)
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);

                    if (row1 < row && row1 >= 0
                        && col1 < col && col1 >= 0
                        && row2 < row && row2 >= 0
                        && col2 < col && col2 >= 0)
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int rows = 0; rows < matrix.GetLength(0); rows++)

                        {

                            for (int cols = 0; cols < matrix.GetLength(1); cols++)

                            {

                                Console.Write(matrix[rows, cols]);
                                Console.Write(' ');

                            }

                            Console.WriteLine();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }

        }
        private static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {

                string[] rowValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            return matrix;
        }
    }
}
