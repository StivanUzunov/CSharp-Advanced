using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.SongsQueu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songsqueu = new Queue<string>(songs);
            while (songsqueu.Any())
            {
                string command = Console.ReadLine();
                List<string> input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0]=="Play")
                {
                    songsqueu.Dequeue();
                }
                else if (input[0] == "Add")
                {
                    input.Remove(input[0]);
                    string songToAdd = String.Join(" ",input);
                    if (songsqueu.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songsqueu.Enqueue(songToAdd);
                    }
                }
                else if (input[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ",songsqueu));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
