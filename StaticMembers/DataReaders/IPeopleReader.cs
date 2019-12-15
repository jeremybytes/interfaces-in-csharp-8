using System.Collections.Generic;

namespace StaticMembers
{
    public interface IPeopleReader
    {
        public List<Person> GetPeople();
        public Person GetPerson(int id);
    }
}