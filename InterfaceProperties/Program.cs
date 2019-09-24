using System;

namespace InterfaceProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // "smallSquare" type is SquareFromInterface
            var smallSquare = new SquareFromInterface(5);
            ShowInterfacePolygon(smallSquare);

            // "largeSquare" type is IRegularPolygon
            IRegularPolygon largeSquare = new SquareFromInterface(20);
            ShowInterfacePolygon(largeSquare);

            // "littleSquare" type is SquareFromAbstractClass
            var littleSquare = new SquareFromAbstractClass(6);
            ShowAbstractPolygon(littleSquare);

            // "bigSquare" type is AbstractRegularPolygon
            AbstractRegularPolygon bigSquare = new SquareFromAbstractClass(21);
            ShowAbstractPolygon(bigSquare);

            // Setting "BadMember" property results in a StackOverflow
            IBadInterface bigError = new BadObject();
            //bigError.BadMember = 2;
        }

        private static void ShowInterfacePolygon(IRegularPolygon polygon)
        {
            Console.WriteLine($"# of Sides:  {polygon.NumberOfSides}");
            Console.WriteLine($"Side Length: {polygon.SideLength}");
            Console.WriteLine($"Perimeter:   {polygon.Perimeter}");
            Console.WriteLine($"Area:        {polygon.Area}");
            Console.WriteLine("----------------------------------");
        }

        private static void ShowAbstractPolygon(AbstractRegularPolygon polygon)
        {
            Console.WriteLine($"# of Sides:  {polygon.NumberOfSides}");
            Console.WriteLine($"Side Length: {polygon.SideLength}");
            Console.WriteLine($"Perimeter:   {polygon.Perimeter}");
            Console.WriteLine($"Area:        {polygon.Area}");
            Console.WriteLine("----------------------------------");
        }

        private static void ShowDynamicPolygon(dynamic polygon)
        {
            Console.WriteLine($"# of Sides:  {polygon.NumberOfSides}");
            Console.WriteLine($"Side Length: {polygon.SideLength}");

            // NOTE: This line fails with the interface because the
            // default implemented member "Perimeter" is not accessible 
            // using "dynamic"
            Console.WriteLine($"Perimeter:   {polygon.Perimeter}");
            
            Console.WriteLine($"Area:        {polygon.Area}");
            Console.WriteLine("----------------------------------");
        }
    }
}
