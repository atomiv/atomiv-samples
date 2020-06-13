using Microsoft.Net.Http.Headers;
using Optivem.Atomiv.Core.Common.Http;
using Optivem.Atomiv.Core.Common.Serialization;
using Optivem.Atomiv.Infrastructure.AspNetCore;
using TextAnalyzer.Web.RestClient.Interface;
using System.Net.Http;

namespace TextAnalyzer.Web.RestClient
{
    public class BaseJsonControllerClient
    {
        public BaseJsonControllerClient(HttpClient httpClient, IJsonSerializer jsonSerializer, string controllerUri)
        {
            Client = new JsonHttpControllerClient(httpClient, jsonSerializer, controllerUri);
        }

        protected JsonHttpControllerClient Client { get; }

        protected HeaderDictionary GetHeaders(HeaderData headerData)
        {
            return new HeaderDictionary(
                (HeaderNames.Authorization, $"Bearer {headerData.Token}"),
                (HeaderNames.AcceptLanguage, headerData.Language));
        }
    }
}
