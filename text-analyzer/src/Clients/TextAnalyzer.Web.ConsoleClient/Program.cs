using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.NewtonsoftJson;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Application.Queries.Customers;
using TextAnalyzer.Web.RestClient;
using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.ConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var serviceProvider = ServiceProviderFactory.Create())
            {
                try
                {
                    Console.WriteLine("Hello World!");

                    await ExecuteAsync(serviceProvider);

                    Console.WriteLine("Finished");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error {ex.Message}");
                }
            }
        }

        private static async Task ExecuteAsync(ServiceProvider serviceProvider)
        {
            var api = serviceProvider.GetRequiredService<IApiClient>();

            var request = new CreateDocumentCommand
            {
                Name = $"My doc {DateTime.Now.ToString()}",
                Text = "This is some text",
            };

            var response = await api.Documents.CreateDocumentAsync(request);

            Console.WriteLine($"Response is: {response.Data.WordCount}");

            Console.ReadKey();
        }
    }
}
