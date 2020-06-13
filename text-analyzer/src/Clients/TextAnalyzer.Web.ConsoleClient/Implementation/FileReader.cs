using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient.Readers
{
    public class FileReader : IReader
    {
        private bool _disposedValue = false;

        public FileReader(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; }

        public Document Read()
        {
            var name = Path.GetFileNameWithoutExtension(FilePath);
            var text = File.ReadAllText(FilePath);

            return new Document(name, text);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                _disposedValue = true;
            }
        }
    }
}
