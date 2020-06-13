using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.NewtonsoftJson;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Application.Queries.Customers;
using TextAnalyzer.Web.ConsoleClient.Interface;
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
                    Console.WriteLine("Starting...");

                    var executor = serviceProvider.GetRequiredService<IExecutor>();

                    await executor.ExecuteAsync();

                    Console.WriteLine("Finished.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error has occurred. Details: {ex.Message}");
                }
            }
        }
    }
}
