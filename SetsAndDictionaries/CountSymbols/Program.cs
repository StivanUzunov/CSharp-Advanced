using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> chars = new SortedDictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!chars.ContainsKey(text[i]))
                {
                    chars.Add(text[i], 1);
                }
                else
                {
                    chars[text[i]]++;
                }
            }
           
            foreach (var kvp in chars)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
