using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            int push = input[0];
            int pop = input[1];
            int n = input[2];
            int[] numbersarr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < push; i++)
            {
                if (numbersarr.Any())
                {
                    stack.Push(numbersarr[i]);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(n))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
