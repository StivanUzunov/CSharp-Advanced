using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> function1 = (name, value) => 
            name.ToCharArray().Select(ch => (int)ch).Sum() >= value;

            Func<List<string>, int, Func<string, int, bool>, string> function2 =  (names, n, function1) =>
            names.FirstOrDefault(name => function1(name, n));

            Console.WriteLine(function2(names, number, function1).ToString());
        }
    }
}
