namespace DynamicAndDefaultImplementation
{
    public class Square : IRegularPolygon
    {
        public int NumberOfSides { get; }
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            NumberOfSides = 4;
            SideLength = sideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
