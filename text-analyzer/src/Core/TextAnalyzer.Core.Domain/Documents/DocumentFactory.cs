using Optivem.Atomiv.Core.Domain;

namespace TextAnalyzer.Core.Domain.Documents
{
    public class DocumentFactory : IDocumentFactory
    {
        private readonly IIdentityGenerator<DocumentIdentity> _bookIdentityGenerator;

        public DocumentFactory(IIdentityGenerator<DocumentIdentity> bookIdentityGenerator)
        {
            _bookIdentityGenerator = bookIdentityGenerator;
        }

        public Document Create(string title, string content)
        {
            var id = _bookIdentityGenerator.Next();

            return new Document(id, title, content);
        }
    }
}
