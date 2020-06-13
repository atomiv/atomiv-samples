using Optivem.Atomiv.Core.Domain;
using System;
using System.Threading.Tasks;

namespace TextAnalyzer.Core.Domain.Orders
{
    public interface IOrderReadonlyRepository : IRepository
    {
        Task<bool> ExistsAsync(Guid orderId);

        Task<long> CountAsync();
    }
}
