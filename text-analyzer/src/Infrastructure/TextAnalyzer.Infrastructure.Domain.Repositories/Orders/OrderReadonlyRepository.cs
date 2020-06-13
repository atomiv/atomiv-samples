using Microsoft.EntityFrameworkCore;
using TextAnalyzer.Core.Domain.Orders;
using TextAnalyzer.Infrastructure.Persistence.Common;
using System;
using System.Threading.Tasks;

namespace TextAnalyzer.Infrastructure.Domain.Repositories.Orders
{
    public class OrderReadonlyRepository : Repository, IOrderReadonlyRepository
    {
        public OrderReadonlyRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<bool> ExistsAsync(Guid orderId)
        {
            return Context.Orders.AsNoTracking()
                .AnyAsync(e => e.Id == orderId);
        }

        public Task<long> CountAsync()
        {
            return Context.Orders.LongCountAsync();
        }
    }
}
