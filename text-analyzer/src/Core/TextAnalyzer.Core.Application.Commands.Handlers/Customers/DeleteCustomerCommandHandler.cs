using System.Threading.Tasks;
using Optivem.Atomiv.Core.Application;
using TextAnalyzer.Core.Application.Commands.Customers;
using TextAnalyzer.Core.Domain.Customers;

namespace TextAnalyzer.Core.Application.Commands.Handlers.Customers
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, DeleteCustomerCommandResponse>
    {
        private readonly ICustomerRepository _customerRepository;

        public DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<DeleteCustomerCommandResponse> HandleAsync(DeleteCustomerCommand request)
        {
            var customerId = new CustomerIdentity(request.Id);

            await _customerRepository.RemoveAsync(customerId);

            return new DeleteCustomerCommandResponse();
        }
    }
}