using Optivem.Atomiv.Infrastructure.SequentialGuid;
using TextAnalyzer.Core.Domain.Products;
using System;

namespace TextAnalyzer.Infrastructure.Persistence.IdentityGenerators
{
    public class ProductIdentityGenerator : IdentityGenerator<ProductIdentity>
    {
        protected override ProductIdentity Create(Guid guid)
        {
            return new ProductIdentity(guid);
        }
    }
}
