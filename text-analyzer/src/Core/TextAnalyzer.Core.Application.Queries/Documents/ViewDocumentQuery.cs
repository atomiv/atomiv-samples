using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Queries.Documents
{
    public class ViewDocumentQuery : IRequest<ViewDocumentQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
