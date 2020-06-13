using Optivem.Atomiv.Core.Domain;

namespace TextAnalyzer.Core.Domain.Documents
{
    public interface IDocumentFactory : IFactory
    {
        Document Create(string title, string content);
    }
}
