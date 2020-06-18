using Microsoft.EntityFrameworkCore;
using Optivem.Atomiv.Core.Application;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Queries.Documents;
using TextAnalyzer.Infrastructure.Domain.Persistence.Records;
using TextAnalyzer.Infrastructure.Persistence.Common;

namespace TextAnalyzer.Infrastructure.Queries.Handlers.Documents
{
    public class ViewDocumentQueryHandler : QueryHandler<ViewDocumentQuery, ViewDocumentQueryResponse>
    {
        public ViewDocumentQueryHandler(DatabaseContext context) : base(context)
        {
        }

        public override async Task<ViewDocumentQueryResponse> HandleAsync(ViewDocumentQuery request)
        {
            var documentRecord = await Context.Documents.AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == request.Id);

            if(documentRecord == null)
            {
                throw new ExistenceException();
            }

            return GetResponse(documentRecord);
        }

        private ViewDocumentQueryResponse GetResponse(DocumentRecord documentRecord)
        {
            return new ViewDocumentQueryResponse
            {
                Id = documentRecord.Id,
                Name = documentRecord.Name,
                Text = documentRecord.Text,
                WordCount = documentRecord.WordCount,
            };
        }
    }
}
