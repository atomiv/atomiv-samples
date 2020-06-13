using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Products;
using TextAnalyzer.Core.Domain.Products;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Products
{
    public class RelistProductCommandValidator : BaseValidator<RelistProductCommand>
    {
        public RelistProductCommandValidator(IProductReadonlyRepository productReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation)
                    => productReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
