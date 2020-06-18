using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.NewtonsoftJson;
using Optivem.Atomiv.Test.EntityFrameworkCore;
using TextAnalyzer.DependencyInjection;
using TextAnalyzer.Web.RestClient;
using TextAnalyzer.Web.RestClient.Interface;
using System.Net.Http;
using TextAnalyzer.Infrastructure.Persistence.Common;

namespace TextAnalyzer.Web.RestApi.IntegrationTest
{
    public class Fixture
    {
        public Fixture()
        {
            Db = DbTestClientFactory.Create<DatabaseContext>(ConfigurationKeys.DatabaseConnectionKey, e => new DatabaseContext(e), ConfigurationKeys.SqlServerOptionsAction);

            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.Test.json");

            var configurationRoot = configurationBuilder.Build();

            var webHostBuilder = new WebHostBuilder()
                .UseStartup<Startup>()
                .UseConfiguration(configurationRoot);

            var services = new ServiceCollection();

            services.AddSingleton(typeof(TestServer), serviceProvider => new TestServer(webHostBuilder));
            services.AddSingleton<IJsonSerializer, JsonSerializer>();

            services.AddTransient<IHttpClientFactory, TestServerHttpClientFactory>();
            services.AddHttpClient<IDocumentControllerClient, DocumentControllerClient>();
            services.AddTransient<IApiClient, ApiClient>();

            var serviceProvider = services.BuildServiceProvider();

            Api = serviceProvider.GetRequiredService<IApiClient>();
        }

        public DbTestClient<DatabaseContext> Db { get; }

        public IApiClient Api { get; }
    }
}