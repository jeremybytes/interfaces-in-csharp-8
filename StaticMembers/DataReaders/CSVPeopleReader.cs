using System;
using System.Collections.Generic;
using System.Linq;

namespace StaticMembers
{
    public class CSVPeopleReader : IPeopleReader
    {
        public IReadOnlyCollection<Person> GetPeople()
        {
            var people = ParseString(IFileLoader.FileData);
            return people;
        }

        public Person GetPerson(int id)
        {
            var people = GetPeople();
            return people?.FirstOrDefault(p => p.Id == id);
        }

        private List<Person> ParseString(string csvData)
        {
            var people = new List<Person>();

            var lines = csvData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                try
                {
                    var elems = line.Split(',');
                    var per = new Person()
                    {
                        Id = Int32.Parse(elems[0]),
                        GivenName = elems[1],
                        FamilyName = elems[2],
                        StartDate = DateTime.Parse(elems[3]),
                        Rating = Int32.Parse(elems[4]),
                        FormatString = elems[5],
                    };
                    people.Add(per);
                }
                catch (Exception)
                {
                    // Skip the bad record, log it, and move to the next record
                    // log.write("Unable to parse record", per);
                }
            }
            return people;
        }
    }
}
