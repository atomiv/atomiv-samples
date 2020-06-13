using Optivem.Atomiv.Core.Application;
using TextAnalyzer.Core.Common.Actions;

namespace TextAnalyzer.Core.Application.Commands.Customers
{
    [RequestAction(RequestType.CreateCustomer)]
    public class CreateCustomerCommand : IRequest<CreateCustomerCommandResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}