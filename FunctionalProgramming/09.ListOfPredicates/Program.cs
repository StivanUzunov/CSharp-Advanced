using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> divisibleNumbers = new List<int>();

            for (int num = 1; num <= n; num++)
            {
                bool isDivisible = true;

                foreach (var number in numbers)
                {
                    Predicate<int> isNotDivisor = x => num % x != 0;

                    if (isNotDivisor(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }
                if (isDivisible)
                {
                    divisibleNumbers.Add(num);
                }
            }
            Console.WriteLine(String.Join(" ",divisibleNumbers));
        }
    }
}
