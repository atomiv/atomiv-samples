using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Commands.Orders
{
    public class SubmitOrderCommand : IRequest<SubmitOrderCommandResponse>
    {
        public Guid Id { get; set; }
    }
}