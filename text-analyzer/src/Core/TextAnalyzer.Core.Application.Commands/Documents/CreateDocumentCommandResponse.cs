using System;

namespace TextAnalyzer.Core.Application.Commands.Documents
{
    public class CreateDocumentCommandResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public long WordCount { get; set; }
    }
}
