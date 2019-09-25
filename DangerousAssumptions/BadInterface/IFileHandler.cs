namespace DangerousAssumptions.BadInterface
{
    public interface IFileHandler
    {
        void Delete(string filename);

        void Rename(string filename, string newfilename) => 
            System.IO.File.Move(filename, newfilename);
    }
}
