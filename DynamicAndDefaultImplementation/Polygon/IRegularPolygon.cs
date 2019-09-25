namespace DynamicAndDefaultImplementation
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; }
        int SideLength { get; set; }

        // Note: These two declarations for GetPerimeter are equivalent:
        //       a method with default implementation.
        //double GetPerimeter()
        //{
        //    return NumberOfSides * SideLength;
        //}

        double GetPerimeter() => NumberOfSides * SideLength;

        double GetArea();
    }
}
