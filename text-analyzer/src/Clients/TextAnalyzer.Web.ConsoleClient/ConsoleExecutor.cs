using System;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Web.ConsoleClient.Interface;
using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class ConsoleExecutor : IExecutor
    {
        private readonly IApiClient _apiClient;
        private readonly IReaderFactory _readerFactory;

        public ConsoleExecutor(IApiClient apiClient, IReaderFactory readerFactory)
        {
            _apiClient = apiClient;
            _readerFactory = readerFactory;
        }

        public async Task ExecuteAsync()
        {
            var reader = _readerFactory.Create();

            var document = reader.Read();

            var request = new CreateDocumentCommand
            {
                Name = document.Name,
                Text = document.Text,
            };

            var response = await _apiClient.Documents.CreateDocumentAsync(request);

            Console.WriteLine($"Word count is: {response.Data.WordCount}");

            Console.ReadKey();
        }
    }
}
