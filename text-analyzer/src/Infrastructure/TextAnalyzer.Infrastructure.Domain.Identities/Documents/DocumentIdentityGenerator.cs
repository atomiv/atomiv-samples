using Optivem.Atomiv.Infrastructure.SequentialGuid;
using System;
using TextAnalyzer.Core.Domain.Documents;

namespace TextAnalyzer.Infrastructure.Domain.Identities.Documents
{
    public class DocumentIdentityGenerator : IdentityGenerator<DocumentIdentity>
    {
        protected override DocumentIdentity Create(Guid guid)
        {
            return new DocumentIdentity(guid);
        }
    }
}
