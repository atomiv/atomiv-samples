namespace TextAnalyzer.Web.RestClient.Interface
{
    public interface IApiClient
    {
        IDocumentControllerClient Documents { get; }
    }
}