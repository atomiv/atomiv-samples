using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.NewtonsoftJson;
using System;
using System.Net.Http;
using System.Reflection;
using TextAnalyzer.Web.ConsoleClient.Interface;
using TextAnalyzer.Web.RestClient;
using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class ServiceProviderFactory
    {
        private const string DefaultEnvironment = "Production";

        private const string ReaderFactoryKey = "ReaderFactory";

        public static ServiceProvider Create(string environment = null)
        {
            if(environment == null)
            {
                // TODO: VC: Might pas from console
                environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            }

            if (environment == null)
            {
                environment = DefaultEnvironment;
            }

            // var environment = "Development";

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings.{environment}.json", true);

            var configuration = configurationBuilder.Build();

            var services = new ServiceCollection();

            var appOptions = configuration.GetSection(AppOptions.Key);

            services.Configure<AppOptions>(appOptions);

            services.AddSingleton<IJsonSerializer, JsonSerializer>();

            services.AddTransient<IHttpClientFactory, HttpClientFactory>();
            services.AddHttpClient<IDocumentControllerClient, DocumentControllerClient>();
            services.AddTransient<IApiClient, ApiClient>();

            services.AddTransient<IExecutor, ConsoleExecutor>();

            var readerFactoryName = appOptions.GetValue<string>(ReaderFactoryKey);

            var assembly = Assembly.GetAssembly(typeof(ServiceProviderFactory));

            var type = assembly.GetType($"TextAnalyzer.Web.ConsoleClient.Factories.{readerFactoryName}");

            if(type == null)
            {
                throw new Exception($"Reader factory {readerFactoryName} is not recognized");
            }

            services.AddTransient(e => (IReaderFactory)Activator.CreateInstance(type));

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
