using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TextAnalyzer.Core.Application.Queries.Customers;
using TextAnalyzer.Infrastructure.Persistence.Common;
using TextAnalyzer.Infrastructure.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Queries.Handlers.Customers
{
    public class FilterCustomersQueryHandler : QueryHandler<FilterCustomersQuery, FilterCustomersQueryResponse>
    {
        public FilterCustomersQueryHandler(DatabaseContext context) : base(context)
        {
        }

        public override async Task<FilterCustomersQueryResponse> HandleAsync(FilterCustomersQuery request)
        {
            var nameSearch = request.NameSearch;
            var limit = request.Limit;

            var customerRecords = await Context.Customers.AsNoTracking()
                .Where(e => e.FirstName.Contains(nameSearch) || e.LastName.Contains(nameSearch))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .Take(limit)
                .ToListAsync();

            var resultRecords = customerRecords
                .Select(GetListCustomersQueryResponse)
                .ToList();

            var totalRecords = await Context.Customers.LongCountAsync();

            return new FilterCustomersQueryResponse
            {
                Records = resultRecords,
                TotalRecords = totalRecords,
            };
        }

        private ListCustomersRecordResponse GetListCustomersQueryResponse(CustomerRecord customerRecord)
        {
            var id = customerRecord.Id;
            var name = $"{customerRecord.FirstName} {customerRecord.LastName}";

            return new ListCustomersRecordResponse
            {
                Id = id,
                Name = name,
            };
        }
    }
}