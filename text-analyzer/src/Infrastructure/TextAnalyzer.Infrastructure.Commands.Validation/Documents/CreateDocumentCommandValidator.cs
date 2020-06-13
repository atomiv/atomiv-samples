using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyzer.Core.Application.Commands.Documents;

namespace TextAnalyzer.Infrastructure.Commands.Validation.Documents
{
    public class CreateDocumentCommandValidator : BaseValidator<CreateDocumentCommand>
    {
        public CreateDocumentCommandValidator()
        {
            RuleFor(e => e.Name).NotEmpty();
            RuleFor(e => e.Text).NotEmpty();
        }
    }
}
