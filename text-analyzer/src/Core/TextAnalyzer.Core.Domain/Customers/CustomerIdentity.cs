using Optivem.Atomiv.Core.Domain;
using System;

namespace TextAnalyzer.Core.Domain.Customers
{
    public class CustomerIdentity : Identity<Guid>
    {
        public CustomerIdentity(Guid value) : base(value)
        {
        }
    }
}