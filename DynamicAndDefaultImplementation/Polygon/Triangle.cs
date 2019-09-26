using System;

namespace DynamicAndDefaultImplementation
{
    public class Triangle : IRegularPolygon
    {
        public int NumberOfSides { get; }
        public int SideLength { get; set; }

        public Triangle(int sideLength)
        {
            NumberOfSides = 3;
            SideLength = sideLength;
        }

        public double GetPerimeter() => NumberOfSides * SideLength;

        public double GetArea() =>
            SideLength * SideLength * Math.Sqrt(3) / 4;
    }
}
