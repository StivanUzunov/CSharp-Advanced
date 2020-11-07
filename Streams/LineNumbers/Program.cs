using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");
            string[] newLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int countOfLetters = CountOfLetters(line);
                int countOfMarks = CountOfPunctuationMarks(line);
                newLines[i] = $"Line {i+1}: {line}({countOfLetters})({countOfMarks})";
            }
            File.WriteAllLines("../../../output.txt", newLines);
        }
        static int CountOfLetters(string line )
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
        static int CountOfPunctuationMarks(string line)
        {
            char[] punctuationMarks = { '-', ',', '.', '!', '?', ';', ':','\'' };
            int counter = 0; 
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (punctuationMarks.Contains(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
