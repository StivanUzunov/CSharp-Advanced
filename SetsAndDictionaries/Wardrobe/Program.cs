using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> colors = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];
                string[] clothes = input[1].Split(',').ToArray();
                if (!colors.ContainsKey(color))
                {
                    colors.Add(color,new Dictionary<string, int>());
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!colors[color].ContainsKey(clothes[j]))
                        {
                            colors[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            colors[color][clothes[j]]++;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!colors[color].ContainsKey(clothes[j]))
                        {
                            colors[color].Add(clothes[j], 1);
                        }
                        else
                        {
                            colors[color][clothes[j]]++;
                        }
                    }
                }
            }
            string[] toFind = Console.ReadLine().Split().ToArray();
            string colorToFind = toFind[0];
            string clothesToFind = toFind[1];
            foreach (var kvp in colors)
            {
                Console.WriteLine($"{kvp.Key} clothes:");
                foreach (var kvp2 in kvp.Value)
                {
                    if (kvp.Key==colorToFind&&kvp2.Key==clothesToFind)
                    {
                        Console.WriteLine($"* {kvp2.Key} - {kvp2.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {kvp2.Key} - {kvp2.Value}");
                }
            }
        }
    }
}
