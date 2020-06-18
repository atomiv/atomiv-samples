using System;
using TextAnalyzer.Web.ConsoleClient.Interface;
using TextAnalyzer.Web.ConsoleClient.Readers;

namespace TextAnalyzer.Web.ConsoleClient.Factories
{
    public class ConsoleInputReaderFactory : IReaderFactory
    {
        public IReader Create()
        {
            Console.WriteLine("Document Name: ");

            var name = Console.ReadLine();

            Console.WriteLine("Document Text: ");

            var text = Console.ReadLine();

            return new InputReader(name, text);
        }
    }
}
