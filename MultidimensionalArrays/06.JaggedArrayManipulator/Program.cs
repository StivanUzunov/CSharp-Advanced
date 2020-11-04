using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];
            for (int row = 0; row < jagged.Length; row++)

            {

                string[] inputNumbers = Console.ReadLine().Split(' ');

                jagged[row] = new double[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)

                {

                    jagged[row][col] = int.Parse(inputNumbers[col]);

                }

            }
            for (int rows = 0; rows < n-1; rows++)
            {
                if (jagged[rows].Length == jagged[rows+1].Length)
                {
                    for (int i = 0; i < jagged[rows].Length; i++)
                    {
                        jagged[rows][i] = jagged[rows][i]*2 ;
                        jagged[rows+1][i] = jagged[rows+1][i]*2;
                    }
                }
                else
                {
                    for (int i = 0; i < jagged[rows].Length; i++)
                    {
                        jagged[rows][i] = jagged[rows][i]/2 ;
                        
                    }
                    for (int i = 0; i < jagged[rows+1].Length; i++)
                    {
                        jagged[rows + 1][i] = jagged[rows + 1][i] / 2;
                    }
                }
            }
            string command = "";
            while (command!="End")
            {
                command = Console.ReadLine();
                if (command=="End")
                {
                    break;
                }
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandOfInput = input[0];
                if (commandOfInput=="Add")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);
                    if (row>=0&&row<n&&col>=0&&col<jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandOfInput == "Subtract")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);
                    if (row >= 0 && row < n && col >= 0 && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            foreach (double[] row in jagged)

            {

                Console.WriteLine(string.Join(" ", row));

            }
        }
    }
}
