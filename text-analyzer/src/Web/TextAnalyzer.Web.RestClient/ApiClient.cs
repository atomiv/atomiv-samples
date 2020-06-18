using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.RestClient
{
    public class ApiClient : IApiClient
    {
        public ApiClient(IDocumentControllerClient documents)
        {
            Documents = documents;
        }

        public IDocumentControllerClient Documents { get; }
    }
}