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
            Queue<int> queu = new Queue<int>();
            int enqueu = input[0];
            int dequeu = input[1];
            int n = input[2];
            int[] numbersarr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < enqueu; i++)
            {
                if (numbersarr.Any())
                {
                    queu.Enqueue(numbersarr[i]);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < dequeu; i++)
            {
                queu.Dequeue();
            }
            if (queu.Contains(n))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queu.Any())
                {
                    Console.WriteLine(queu.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
