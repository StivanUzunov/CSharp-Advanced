using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(curr))
                {
                    numbers.Add(curr, 1);
                }
                else
                {
                    numbers[curr]++;
                }
                   
                
            }
            foreach(var kvp in numbers)
            {
                if (kvp.Value%2==0)
                {
                    Console.WriteLine(kvp.Key);
                    break;
                }
            }
        }
    }
}
