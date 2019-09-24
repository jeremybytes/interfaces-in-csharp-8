namespace InterfaceProperties
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; }
        int SideLength { get; set; }

        // Note: These two lines of code are equivalent:
        //       a calculated property with only a getter.
        //double Perimeter { get => NumberOfSides * SideLength; }
        double Perimeter => NumberOfSides * SideLength;

        double Area { get; }
    }
}
