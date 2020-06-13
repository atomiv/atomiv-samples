using System;

namespace TextAnalyzer.Core.Application.Commands.Products
{
    public class RelistProductCommandResponse
    {
        public Guid Id { get; set; }

        public bool IsListed { get; set; }
    }
}
