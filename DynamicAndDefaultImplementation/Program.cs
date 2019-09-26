using Microsoft.CSharp.RuntimeBinder;
using System;

namespace DynamicAndDefaultImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            // "smallSquare" type is Square
            var smallSquare = new Square(5);
            ShowInterfacePolygon(smallSquare);

            try
            {
                ShowDynamicPolygon(smallSquare);
            }
            catch (RuntimeBinderException ex)
            {
                // This call throws an exception because
                // Square does not have a "GetPerimeter" method.
                Console.WriteLine("----------------------------------");
                Console.WriteLine("RuntimeBinderException thrown.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------------------------------");
            }

            // "largeSquare" type is IRegularPolygon
            IRegularPolygon largeSquare = new Square(20);
            ShowInterfacePolygon(largeSquare);

            try
            {
                ShowDynamicPolygon(largeSquare);
            }
            catch (RuntimeBinderException ex)
            {
                // This call throws an exception because
                // the runtime binder cannot see the default
                // "GetPerimeter" method on the interface.
                Console.WriteLine("----------------------------------");
                Console.WriteLine("RuntimeBinderException thrown.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------------------------------");
            }

            // "triangle" type is IRegularPolygon
            IRegularPolygon triangle = new Triangle(10);
            ShowInterfacePolygon(triangle);
            ShowDynamicPolygon(triangle);
        }

        private static void ShowInterfacePolygon(IRegularPolygon polygon)
        {
            Console.WriteLine($"# of Sides:  {polygon.NumberOfSides}");
            Console.WriteLine($"Side Length: {polygon.SideLength}");
            Console.WriteLine($"Perimeter:   {polygon.GetPerimeter()}");
            Console.WriteLine($"Area:        {polygon.GetArea()}");
            Console.WriteLine("----------------------------------");
        }

        private static void ShowDynamicPolygon(dynamic polygon)
        {
            Console.WriteLine($"# of Sides:  {polygon.NumberOfSides}");
            Console.WriteLine($"Side Length: {polygon.SideLength}");

            // NOTE: This line fails with the interface because the
            // default implemented member "GetPerimeter()" is not accessible 
            // using "dynamic"
            Console.WriteLine($"Perimeter:   {polygon.GetPerimeter()}");

            Console.WriteLine($"Area:        {polygon.GetArea()}");
            Console.WriteLine("----------------------------------");
        }
    }
}
