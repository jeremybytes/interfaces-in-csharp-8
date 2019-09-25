using DangerousAssumptions.SlowPerformance;
using System;

namespace DangerousAssumptions
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader<int> fibReader = new FibonacciReader();
            foreach (var number in fibReader.GetItems())
                Console.Write($"{number}, ");
            Console.WriteLine("\n----------------------------------");
            int index = 5;
            Console.WriteLine($"Number at index {index}: {fibReader.GetItemAt(index)}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

        }
    }
}
