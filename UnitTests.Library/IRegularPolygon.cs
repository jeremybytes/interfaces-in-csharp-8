namespace UnitTests.Library
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; }
        int SideLength { get; set; }

        double GetPerimeter() => NumberOfSides * SideLength;
        double GetArea();
    }
}
