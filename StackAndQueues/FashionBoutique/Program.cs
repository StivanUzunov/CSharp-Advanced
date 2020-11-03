using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int capacityOfARack = int.Parse(Console.ReadLine());
            int racksCounter = 1;
            int sum = 0;
            Stack<int> stack = new Stack<int>(clothes);

            while (stack.Any())
            {
                if (capacityOfARack<sum+stack.Peek())
                {
                    racksCounter++;
                    sum = 0;
                }
                sum += stack.Pop();

            }
            Console.WriteLine(racksCounter);
        }
    }
}
