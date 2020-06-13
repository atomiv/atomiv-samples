using Optivem.Atomiv.Core.Domain;
using System.Threading.Tasks;

namespace TextAnalyzer.Core.Domain.Documents
{
    public interface IDocumentRepository : IRepository
    {
        public void AddDocument(Document document);

        public Task<Document> GetDocumentAsync(DocumentIdentity id);
    }
}
