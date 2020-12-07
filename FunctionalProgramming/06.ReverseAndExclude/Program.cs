using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            int number = int.Parse(Console.ReadLine());
            Func<int, bool> predicate = n => n % number != 0;

            Action<List<int>> print = n => Console.WriteLine(string.Join(" ", n));

            numbers = numbers.Where(predicate)
                  .ToList();
            print(numbers);
        }
    }
}
