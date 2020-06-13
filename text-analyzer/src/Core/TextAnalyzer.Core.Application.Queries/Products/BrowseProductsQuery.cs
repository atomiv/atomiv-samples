using Optivem.Atomiv.Core.Application;

namespace TextAnalyzer.Core.Application.Queries.Products
{
    public class BrowseProductsQuery : IRequest<BrowseProductsQueryResponse>
    {
        public int Page { get; set; }

        public int Size { get; set; }
    }
}