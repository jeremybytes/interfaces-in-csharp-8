using System;

namespace InterfaceProperties
{
    public abstract class AbstractRegularPolygon
    {
        private int _numberOfSides;
        public int NumberOfSides
        {
            get { return _numberOfSides; }
            set
            {
                if (value < 3)
                    throw new ArgumentOutOfRangeException("NumberOfSides must be 3 or greater");
                _numberOfSides = value;
            }
        }

        private int _sideLength;
        public int SideLength
        {
            get { return _sideLength; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("SideLength must be greater than 0");
                _sideLength = value;
            }
        }


        public AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public double Perimeter => NumberOfSides * SideLength;

        abstract public double Area { get; }
    }
}
