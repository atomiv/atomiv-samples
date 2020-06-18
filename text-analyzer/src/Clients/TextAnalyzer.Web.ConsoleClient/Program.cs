using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using TextAnalyzer.Web.ConsoleClient.Interface;

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
