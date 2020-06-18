using System;
using TextAnalyzer.Web.ConsoleClient.Interface;
using TextAnalyzer.Web.ConsoleClient.Readers;

namespace TextAnalyzer.Web.ConsoleClient.Factories
{
    public class ConsoleFileReaderFactory : IReaderFactory
    {
        public IReader Create()
        {
            Console.WriteLine("Document File Path: ");

            var filePath = Console.ReadLine();

            return new FileReader(filePath);
        }
    }
}
