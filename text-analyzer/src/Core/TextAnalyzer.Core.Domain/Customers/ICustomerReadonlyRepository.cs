using Optivem.Atomiv.Core.Domain;
using System;
using System.Threading.Tasks;

namespace TextAnalyzer.Core.Domain.Customers
{
    public interface ICustomerReadonlyRepository : IRepository
    {
        Task<bool> ExistsAsync(Guid customerId);

        Task<long> CountAsync();
    }
}
