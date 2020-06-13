using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Customers;
using TextAnalyzer.Core.Domain.Customers;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Customers
{
    public class DeleteCustomerCommandValidator : BaseValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator(ICustomerReadonlyRepository customerReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation)
                    => customerReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
