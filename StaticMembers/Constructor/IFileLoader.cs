using System;
using System.IO;

namespace StaticMembers
{
    public interface IFileLoader
    {
        private static string fileName = "People.txt";

        public static string FileData;

        static IFileLoader()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + fileName;
            using (var reader = new StreamReader(filePath))
            {
                FileData = reader.ReadToEnd();
            }
        }
    }
}
