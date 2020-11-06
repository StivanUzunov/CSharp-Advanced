using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = numbers[0];
            int m = numbers[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }
            for (int i = 0; i < m; i++)
            {

                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }
            if (n>=m)
            {
                firstSet.IntersectWith(secondSet);
                Console.WriteLine(String.Join(' ', firstSet));
            }
            else
            {
                secondSet.IntersectWith(firstSet);
                Console.WriteLine(String.Join(' ', secondSet));
            }
           

        }
    }
}
