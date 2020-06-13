using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.NewtonsoftJson;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TextAnalyzer.Web.RestClient;
using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class ServiceProviderFactory
    {
        private const string DefaultEnvironment = "Production";

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

            services.Configure<ApiOptions>(configuration.GetSection(ApiOptions.Api));

            services.AddSingleton<IJsonSerializer, JsonSerializer>();

            services.AddTransient<IHttpClientFactory, HttpClientFactory>();
            services.AddHttpClient<IDocumentControllerClient, DocumentControllerClient>();
            services.AddHttpClient<ICustomerControllerClient, CustomerControllerClient>();
            services.AddHttpClient<IOrderControllerClient, OrderControllerClient>();
            services.AddHttpClient<IProductControllerClient, ProductControllerClient>();
            services.AddTransient<IApiClient, ApiClient>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
