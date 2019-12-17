using System;

namespace StaticMain
{
    public interface IHelloWorld
    {
        static void Main(string[] args)
        {
            if (args?.Length == 0)
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine($"Hello {args[0]}!");
        }
    }
}
