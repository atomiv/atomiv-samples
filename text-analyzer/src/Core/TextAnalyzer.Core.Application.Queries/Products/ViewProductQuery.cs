using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Queries.Products
{
    public class ViewProductQuery : IRequest<ViewProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}