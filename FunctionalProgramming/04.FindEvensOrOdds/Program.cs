using System;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string evenOrOdd = Console.ReadLine();
            Predicate<int> predicate = evenOrOdd == "odd" ? 
                new Predicate<int>((n) => n % 2 != 0) : 
                new Predicate<int>((n) => n % 2 == 0);
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
