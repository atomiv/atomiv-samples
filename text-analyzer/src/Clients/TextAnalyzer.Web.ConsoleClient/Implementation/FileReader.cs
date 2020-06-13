using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient.Readers
{
    public class FileReader : IReader
    {
        private bool _disposedValue = false;

        public FileReader(string path)
        {
            Path = path;
        }

        public string Path { get; }

        public Document Read()
        {
            throw new NotImplementedException();
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
