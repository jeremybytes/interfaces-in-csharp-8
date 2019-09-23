namespace InterfaceProperties
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; }
        int SideLength { get; set; }

        // Note: These two lines of code are equivalent:
        //       a calculated property with only a getter.
        //int Perimeter { get => NumberOfSides * SideLength; }
        int Perimeter => NumberOfSides * SideLength;

        int Area { get; }
    }
}
