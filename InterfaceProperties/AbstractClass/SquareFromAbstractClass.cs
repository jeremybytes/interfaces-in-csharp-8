namespace InterfaceProperties
{
    public class SquareFromAbstractClass : AbstractRegularPolygon
    {
        public SquareFromAbstractClass(int sideLength) : 
            base(4, sideLength)
        { }

        public override int Area => SideLength * SideLength;
    }
}
