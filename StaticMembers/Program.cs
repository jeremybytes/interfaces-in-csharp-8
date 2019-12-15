using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use default readerType
            DisplayPeople();

            // Set readerType to valid type
            IReaderFactory.readerType = typeof(CSVPeopleReader);
            DisplayPeople();

            // Set readerType to invalid type
            IReaderFactory.readerType = typeof(Person);
            DisplayPeople();
        }

        public static void DisplayPeople()
        {
            try
            {
                IPeopleReader reader = IReaderFactory.GetReader();
                Console.WriteLine(reader.GetType());

                var people = reader.GetPeople();
                foreach (var person in people)
                    Console.WriteLine(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}:\n   {ex.Message}");
            }
            finally
            {
                Console.WriteLine("===================");
            }
        }
    }
}
