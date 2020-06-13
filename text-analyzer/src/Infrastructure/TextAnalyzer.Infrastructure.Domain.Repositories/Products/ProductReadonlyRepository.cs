using Microsoft.EntityFrameworkCore;
using TextAnalyzer.Core.Domain.Products;
using TextAnalyzer.Infrastructure.Persistence.Common;
using System;
using System.Threading.Tasks;

namespace TextAnalyzer.Infrastructure.Domain.Repositories.Products
{
    public class ProductReadonlyRepository : Repository, IProductReadonlyRepository
    {
        public ProductReadonlyRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<bool> ExistsAsync(Guid productId)
        {
            return Context.Products.AsNoTracking()
                .AnyAsync(e => e.Id == productId);
        }

        public Task<long> CountAsync()
        {
            return Context.Products.LongCountAsync();
        }

        public async Task<decimal?> GetPriceAsync(Guid productId)
        {
            var productRecord = await Context.Products.AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == productId);

            if (productRecord == null)
            {
                return null;
            }

            return productRecord.ListPrice;
        }
    }
}
