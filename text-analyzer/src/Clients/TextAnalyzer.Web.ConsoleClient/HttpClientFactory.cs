using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private readonly IOptions<ApiOptions> _options;

        public HttpClientFactory(IOptions<ApiOptions> options)
        {
            _options = options;
        }

        public HttpClient CreateClient(string name)
        {
            var baseAddressUrl = _options.Value.Connection;

            var baseAddress = new Uri(baseAddressUrl);

            return new HttpClient
            {
                BaseAddress = baseAddress,
            };
        }
    }
}
