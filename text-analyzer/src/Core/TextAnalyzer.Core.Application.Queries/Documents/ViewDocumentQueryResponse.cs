using System;

namespace TextAnalyzer.Core.Application.Queries.Documents
{
    public class ViewDocumentQueryResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }

        public long WordCount { get; set; }
    }
}
