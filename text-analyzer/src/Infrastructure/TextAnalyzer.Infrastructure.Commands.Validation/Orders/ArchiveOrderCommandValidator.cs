using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Orders;
using TextAnalyzer.Core.Domain.Orders;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Orders
{
    public class ArchiveOrderCommandValidator : BaseValidator<ArchiveOrderCommand>
    {
        public ArchiveOrderCommandValidator(IOrderReadonlyRepository orderReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation)
                    => orderReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
