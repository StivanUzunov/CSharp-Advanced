﻿using System;
using System.Linq;

namespace _02.KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> names = (name) =>
            {
                Console.WriteLine("Sir " + name);
            };
            Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(names);
        }
    }
}
