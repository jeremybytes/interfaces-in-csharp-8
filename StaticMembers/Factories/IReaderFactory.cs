using System;

namespace StaticMembers
{
    public interface IReaderFactory
    {
        private static IPeopleReader savedReader;
        public static Type readerType = typeof(HardCodedPeopleReader);

        public static IPeopleReader GetReader()
        {
            if (savedReader?.GetType() == readerType)
                return savedReader;

            object readerObject = Activator.CreateInstance(readerType);
            
            savedReader = readerObject as IPeopleReader;
            if (savedReader is null)
            {
                throw new InvalidOperationException(
                    $"readerType '{readerType}' does not implement 'IPeopleReader'");
            }

            return savedReader;
        }
    }
}
