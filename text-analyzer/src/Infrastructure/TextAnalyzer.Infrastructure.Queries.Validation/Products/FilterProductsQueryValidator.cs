using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Queries.Products;

namespace TextAnalyzer.Infrastructure.Queries.Validation.Products
{
    public class FilterProductsQueryValidator : BaseValidator<FilterProductsQuery>
    {
        public FilterProductsQueryValidator()
        {

        }
    }
}
