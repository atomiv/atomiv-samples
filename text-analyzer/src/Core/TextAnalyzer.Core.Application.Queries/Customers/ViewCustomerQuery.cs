using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Queries.Customers
{
    public class ViewCustomerQuery : IRequest<ViewCustomerQueryResponse>
    {
        public Guid Id { get; set; }
    }
}