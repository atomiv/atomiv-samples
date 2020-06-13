using System;
using System.Threading.Tasks;
using TextAnalyzer.Core.Domain.Documents;
using TextAnalyzer.Infrastructure.Domain.Persistence.Records;
using TextAnalyzer.Infrastructure.Persistence.Common;

namespace TextAnalyzer.Infrastructure.Domain.Repositories.Documents
{
    public class DocumentRepository : Repository, IDocumentRepository
    {
        public DocumentRepository(DatabaseContext context) : base(context)
        {
        }

        public void AddDocument(Document document)
        {
            var documentRecord = GetDocumentRecord(document);
            Context.Documents.Add(documentRecord);
        }

        public Task<Document> GetDocumentAsync(DocumentIdentity id)
        {
            throw new NotImplementedException();
        }

        private DocumentRecord GetDocumentRecord(Document document)
        {
            return new DocumentRecord
            {
                Id = document.Id,
                Name = document.Name,
                Text = document.Text,
                WordCount = document.GetWordCount(),
            };
        }
    }
}
