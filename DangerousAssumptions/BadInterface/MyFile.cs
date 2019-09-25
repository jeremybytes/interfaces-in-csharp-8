using System.IO;

namespace DangerousAssumptions.BadInterface
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
