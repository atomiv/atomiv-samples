using Optivem.Atomiv.Infrastructure.SequentialGuid;
using TextAnalyzer.Core.Domain.Orders;
using System;

namespace TextAnalyzer.Infrastructure.Persistence.IdentityGenerators
{
    public class OrderItemIdentityGenerator : IdentityGenerator<OrderItemIdentity>
    {
        protected override OrderItemIdentity Create(Guid guid)
        {
            return new OrderItemIdentity(guid);
        }
    }
}
