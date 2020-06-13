using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Commands.Products
{
    public class RelistProductCommand : IRequest<RelistProductCommandResponse>
    {
        public Guid Id { get; set; }
    }
}