using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minfunction = (arr) =>
             {
                 int minValue = int.MaxValue;
                 foreach (var num in arr)
                 {
                     if (num<minValue)
                     {
                         minValue = num;
                     }
                 }
                 return minValue;
             };
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(minfunction(arr));
        }
    }
}
