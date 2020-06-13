using Optivem.Atomiv.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TextAnalyzer.Core.Domain.Products
{
    public interface IProductProviderService : IService
    {
        public Task<IEnumerable<Product>> GetProductsAsync();
    }
}
