using Microsoft.EntityFrameworkCore;
using TextAnalyzer.Core.Application.Queries.Orders;
using TextAnalyzer.Infrastructure.Persistence.Common;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyzer.Infrastructure.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Queries.Handlers.Orders
{
    public class FilterOrdersQueryHandler : QueryHandler<FilterOrdersQuery, FilterOrdersQueryResponse>
    {
        public FilterOrdersQueryHandler(DatabaseContext context) : base(context)
        {
        }

        public override async Task<FilterOrdersQueryResponse> HandleAsync(FilterOrdersQuery request)
        {
            var orderRecords = await Context.Orders.AsNoTracking()
                .OrderBy(e => e.Id)
                .ToListAsync();

            var resultRecords = orderRecords.Select(GetIdNameResult).ToList();
            var totalRecords = await Context.Orders.LongCountAsync();

            return new FilterOrdersQueryResponse
            {
                Records = resultRecords,
                TotalRecords = totalRecords,
            };
        }

        private ListOrdersRecordQueryResponse GetIdNameResult(OrderRecord record)
        {
            var name = record.Id.ToString();

            return new ListOrdersRecordQueryResponse
            {
                Id = record.Id,
                Name = name,
            };
        }
    }
}