using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Orders;
using TextAnalyzer.Core.Domain.Orders;
using TextAnalyzer.Core.Domain.Products;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Orders
{
    public class EditOrderRequestValidator : BaseValidator<EditOrderCommand>
    {
        public EditOrderRequestValidator(IOrderReadonlyRepository orderReadonlyRepository, IProductReadonlyRepository productReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation)
                    => orderReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);

            RuleFor(e => e.OrderItems).NotNull();

            RuleForEach(e => e.OrderItems)
                .SetValidator(new UpdateOrderItemCommandValidator(productReadonlyRepository));
        }
    }

    public class UpdateOrderItemCommandValidator : BaseValidator<UpdateOrderItemCommand>
    {
        public UpdateOrderItemCommandValidator(IProductReadonlyRepository productReadonlyRepository)
        {
            RuleFor(e => e.ProductId)
                .MustAsync((command, context, cancellation)
                    => productReadonlyRepository.ExistsAsync(command.ProductId));
        }
    }
}