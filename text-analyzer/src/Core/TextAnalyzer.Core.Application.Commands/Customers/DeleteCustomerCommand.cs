using Optivem.Atomiv.Core.Application;
using System;

namespace TextAnalyzer.Core.Application.Commands.Customers
{
    public class DeleteCustomerCommand : IRequest<DeleteCustomerCommandResponse>
    {
        public Guid Id { get; set; }
    }
}