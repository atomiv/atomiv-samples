using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;
using System;

namespace TextAnalyzer.Infrastructure.Domain.Persistence.Records
{
    public class DocumentRecord : Record<Guid>
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public long WordCount { get; set; }
    }
}
