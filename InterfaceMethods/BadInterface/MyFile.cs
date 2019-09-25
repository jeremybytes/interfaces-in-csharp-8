using System.IO;

namespace InterfaceMethods
{
    public class MyFile : IFileHandler
    {
        public void Delete(string filename)
        {
            if (File.Exists(filename))
                File.Delete(filename);
        }
    }
}
