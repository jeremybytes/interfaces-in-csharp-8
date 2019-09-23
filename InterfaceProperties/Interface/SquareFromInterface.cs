namespace InterfaceProperties
{
    public class SquareFromInterface : IRegularPolygon
    {
        public int NumberOfSides { get; }
        public int SideLength { get; set; }

        public SquareFromInterface(int sideLength)
        {
            NumberOfSides = 4;
            SideLength = sideLength;
        }

        public int Area => SideLength * SideLength;
    }
}
