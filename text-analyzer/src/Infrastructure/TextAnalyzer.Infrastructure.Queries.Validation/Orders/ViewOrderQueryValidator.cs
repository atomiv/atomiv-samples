using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Queries.Orders;
using TextAnalyzer.Core.Domain.Orders;

namespace TextAnalyzer.Infrastructure.Queries.Validation.Orders
{
    public class ViewOrderQueryValidator : BaseValidator<ViewOrderQuery>
    {
        public ViewOrderQueryValidator(IOrderReadonlyRepository orderReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((query, context, cancellation)
                    => orderReadonlyRepository.ExistsAsync(query.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
