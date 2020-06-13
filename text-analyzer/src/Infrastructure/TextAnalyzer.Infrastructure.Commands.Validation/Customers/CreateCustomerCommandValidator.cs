using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Customers;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Customers
{
    public class CreateCustomerCommandValidator : BaseValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(e => e.FirstName).NotNull();
            RuleFor(e => e.LastName).NotNull();
        }
    }
}