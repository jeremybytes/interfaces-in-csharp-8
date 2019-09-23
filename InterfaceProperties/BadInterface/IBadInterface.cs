namespace InterfaceProperties
{
    public interface IBadInterface
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

        // Note: If there is a default implementation for "get",
        // then "set" cannot be abstraction (i.e., to be implemented
        // by the implementing class/struct).
        
        //int NotAllowed
        //{
        //    get => 20;
        //    abstract set;
        //}


        // The same is true for an abstract "get" with a default "set",
        // even if the setter does nothing. 
        
        //int AlsoNotAllowed
        //{
        //    abstract get;
        //    set { }
        //}
    }
}
