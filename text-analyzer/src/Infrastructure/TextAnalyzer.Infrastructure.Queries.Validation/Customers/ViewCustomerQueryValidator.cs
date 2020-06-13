using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Queries.Customers;
using TextAnalyzer.Core.Domain.Customers;

namespace TextAnalyzer.Infrastructure.Queries.Validation.Customers
{
    public class ViewCustomerQueryValidator : BaseValidator<ViewCustomerQuery>
    {
        public ViewCustomerQueryValidator(ICustomerReadonlyRepository customerReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((query, context, cancellation)
                    => customerReadonlyRepository.ExistsAsync(query.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
