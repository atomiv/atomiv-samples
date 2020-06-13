﻿using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using TextAnalyzer.Core.Application.Commands.Customers;
using TextAnalyzer.Core.Domain.Customers;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Customers
{
    public class EditCustomerCommandValidator : BaseValidator<EditCustomerCommand>
    {
        public EditCustomerCommandValidator(ICustomerReadonlyRepository customerReadonlyRepository)
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .MustAsync((command, context, cancellation) 
                    => customerReadonlyRepository.ExistsAsync(command.Id))
                .WithErrorCode(ValidationErrorCodes.NotFound);

            RuleFor(e => e.FirstName)
                .NotNull();

            RuleFor(e => e.LastName)
                .NotNull();
        }
    }
}