using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] chemical = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < chemical.Length; j++)
                {
                    chemicals.Add(chemical[j]);
                }
               
            }
            Console.WriteLine(String.Join(' ',chemicals));
        }
    }
}
