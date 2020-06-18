using System;
using TextAnalyzer.Web.ConsoleClient.Interface;
using TextAnalyzer.Web.ConsoleClient.Readers;

namespace TextAnalyzer.Web.ConsoleClient.Factories
{
    public class ConsoleDatabaseReaderFactory : IReaderFactory
    {
        public IReader Create()
        {
            Console.WriteLine("Database Connection String: ");

            var connectionString = Console.ReadLine();

            Console.WriteLine("Document Name: ");

            var documentName = Console.ReadLine();

            return new DatabaseReader(connectionString, documentName);
        }
    }
}
