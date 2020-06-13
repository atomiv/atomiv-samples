using Optivem.Atomiv.Infrastructure.SequentialGuid;
using TextAnalyzer.Core.Domain.Orders;
using System;

namespace TextAnalyzer.Infrastructure.Persistence.IdentityGenerators
{
    public class OrderIdentityGenerator : IdentityGenerator<OrderIdentity>
    {
        protected override OrderIdentity Create(Guid guid)
        {
            return new OrderIdentity(guid);
        }
    }
}
