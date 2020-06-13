using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient.Readers
{
    public class ConsoleReader : IReader
    {
        private bool _disposedValue = false;

        public Document Read()
        {
            Console.WriteLine("Please write the Document Name: ");

            var name = Console.ReadLine();

            Console.WriteLine("Please write the Document Text: ");

            var text = Console.ReadLine();

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
