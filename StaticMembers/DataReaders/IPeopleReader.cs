using System.Collections.Generic;

namespace StaticMembers
{
    public interface IPeopleReader
    {
        public IReadOnlyCollection<Person> GetPeople();
        public Person GetPerson(int id);
    }
}