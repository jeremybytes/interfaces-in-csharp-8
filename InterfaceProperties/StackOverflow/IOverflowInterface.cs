namespace InterfaceProperties
{
    public interface IOverflowInterface
    {
        // Although this compiles, the setter results in a
        // StackOverflow as the setter calls the setter again.
        // There is no way to have a backing field in an interface
        // to allow for syntax similar to a full property.
        int BadMember
        {
            get => 1;
            set { BadMember = value; }
        }
    }
}
