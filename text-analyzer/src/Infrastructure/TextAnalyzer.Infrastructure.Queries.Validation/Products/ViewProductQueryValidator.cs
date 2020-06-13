using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Queries.Products;
using TextAnalyzer.Core.Domain.Products;

namespace TextAnalyzer.Infrastructure.Queries.Validation.Products
{
    public class ViewProductQueryValidator : BaseValidator<ViewProductQuery>
    {
        public ViewProductQueryValidator(IProductReadonlyRepository productReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((query, context, cancellation)
                    => productReadonlyRepository.ExistsAsync(query.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
