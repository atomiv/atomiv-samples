using Optivem.Atomiv.Core.Domain;
using System;

namespace TextAnalyzer.Core.Domain.Documents
{
    public class DocumentIdentity : Identity<Guid>
    {
        public DocumentIdentity(Guid value) : base(value)
        {
        }
    }
}
