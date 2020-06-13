using Optivem.Atomiv.Core.Domain;
using System;

namespace TextAnalyzer.Core.Domain.Products
{
    public class ProductIdentity : Identity<Guid>
    {
        public ProductIdentity(Guid value)
            : base(value)
        {
        }
    }
}