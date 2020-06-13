using Optivem.Atomiv.Core.Domain;

namespace TextAnalyzer.Core.Domain.Documents
{
    public class Document : Entity<DocumentIdentity>
    {
        public Document(DocumentIdentity id, string name, string text)
            : base(id)
        {
            Name = name;
            Text = text;
        }

        public string Name { get; }

        public string Text { get; }

        public long GetWordCount()
        {
            // TODO: VC: How about punctuation marks?

            var words = Text.Split(' ');

            return words.Length;
        }
    }
}
