namespace InterfaceProperties
{
    public class SquareFromAbstractClass : AbstractRegularPolygon
    {
        public SquareFromAbstractClass(int sideLength) : 
            base(4, sideLength)
        { }

        public override double Area => SideLength * SideLength;
    }
}
