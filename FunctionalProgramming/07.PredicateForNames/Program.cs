using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Func<List<string>, List<string>> function = (arr) =>
             {
                 List<string> filteredNames = new List<string>();
                 for (int i = 0; i < arr.Count; i++)
                 {
                     if (arr[i].Length<=n)
                     {
                         filteredNames.Add(arr[i]);
                     }
                 }
                 return filteredNames;
             };
            Console.WriteLine(String.Join(Environment.NewLine,function(names)));
        }
    }
}
