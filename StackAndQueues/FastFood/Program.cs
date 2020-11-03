using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] customersarr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> customers = new Queue<int>(customersarr);
            Console.WriteLine(customers.Max());
            for (int i = 0; i < customersarr.Length; i++)
            {
                if (foodQuantity<=0)
                {
                    break;
                }
                if (foodQuantity>=customers.Peek())
                { 
                    foodQuantity -= customers.Dequeue(); 
                }
                else
                {
                    break;
                }

            }
            if (customers.Any())
            {
                Console.Write("Orders left: ");
                Console.WriteLine(String.Join(' ', customers));
                
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
