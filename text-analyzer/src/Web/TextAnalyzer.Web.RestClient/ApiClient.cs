using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.RestClient
{
    public class ApiClient : IApiClient
    {
        public ApiClient(IDocumentControllerClient documents, ICustomerControllerClient customers, IOrderControllerClient orders, IProductControllerClient products)
        {
            Documents = documents;
            Customers = customers;
            Orders = orders;
            Products = products;
        }

        public IDocumentControllerClient Documents { get; }

        public ICustomerControllerClient Customers { get; }

        public IOrderControllerClient Orders { get; }

        public IProductControllerClient Products { get; }
    }
}