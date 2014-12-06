using System;
using System.IO;

namespace wmwood.Raj.Tests
{
    public class TempFile : IDisposable
    {
        public TempFile()
        {
            Path = System.IO.Path.GetTempFileName();
        }

        public TempFile(string fileContents) : this()
        {
            File.WriteAllText(Path, fileContents);
        }

        public string Path { get; private set; }

        public void Dispose()
        {
            File.Delete(Path);
        }
    }
}