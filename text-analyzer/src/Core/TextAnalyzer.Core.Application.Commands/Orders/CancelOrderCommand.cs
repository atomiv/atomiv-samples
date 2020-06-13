using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Commands.Orders
{
    public class CancelOrderCommand : IRequest<CancelOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}