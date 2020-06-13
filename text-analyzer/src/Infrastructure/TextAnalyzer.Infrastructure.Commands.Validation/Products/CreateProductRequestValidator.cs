using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Products;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Products
{
    public class CreateProductRequestValidator : BaseValidator<CreateProductCommand>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(e => e.Code).NotNull();
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.UnitPrice).GreaterThan(0);
        }
    }
}