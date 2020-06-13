using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Commands.Orders
{
    public class ArchiveOrderCommand : IRequest<ArchiveOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}