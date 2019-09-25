using System;
using System.Collections.Generic;

namespace DangerousAssumptions.BadInterface
{
    public class MemoryStringFileHandler : IFileHandler
    {
        private Dictionary<string, string> Files;

        public MemoryStringFileHandler()
        {
            Files = new Dictionary<string, string>();
        }

        public void Write(string filename, string content)
        {
            if (filename == null) 
                throw new ArgumentNullException(nameof(filename));

            if (Files.TryAdd(filename, content))
            {
                // everything's fine
            }
            else
            {
                throw new ArgumentException($"{filename} already exists");
            }
        }

        public string Read(string filename)
        {
            if (filename == null) 
                throw new ArgumentNullException(nameof(filename));

            if (Files.TryGetValue(filename, out string content))
            {
                return content;
            }
            else
            {
                throw new ArgumentException($"{filename} is not valid");
            }
        }

        public void Delete(string filename)
        {
            if (Files.ContainsKey(filename))
            {
                Files.Remove(filename);
            }
            else
            {
                throw new ArgumentException($"{filename} is not valid");
            }
        }
    }
}
