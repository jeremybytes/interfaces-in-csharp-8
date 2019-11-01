namespace AccessModifiers.Public
{
    public class Customer
    {
        // Class members default to "private"
        // These fields are both "private"
        string _familyName;
        private string _givenName;

        public int Id { get; set; }

        public string FamilyName
        {
            get { return _familyName; }
            set
            {
                if (value == _familyName)
                    return;
                _familyName = value;
            }
        }

        public string GivenName
        {
            get { return _givenName; }
            set
            {
                if (value == _givenName)
                    return;
                _givenName = value;
            }
        }

    }
}
