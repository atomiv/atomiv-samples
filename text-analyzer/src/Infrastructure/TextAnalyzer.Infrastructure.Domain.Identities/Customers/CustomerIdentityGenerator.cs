using Optivem.Atomiv.Infrastructure.SequentialGuid;
using TextAnalyzer.Core.Domain.Customers;
using System;

namespace TextAnalyzer.Infrastructure.Persistence.IdentityGenerators
{
    public class CustomerIdentityGenerator : IdentityGenerator<CustomerIdentity>
    {
        protected override CustomerIdentity Create(Guid guid)
        {
            return new CustomerIdentity(guid);
        }
    }
}
