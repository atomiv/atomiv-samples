using FluentValidation;
using Optivem.Atomiv.Infrastructure.FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyzer.Core.Application.Queries.Documents;

namespace TextAnalyzer.Infrastructure.Queries.Validation.Documents
{
    public class ViewDocumentQueryValidator : BaseValidator<ViewDocumentQuery>
    {
        public ViewDocumentQueryValidator()
        {
            RuleFor(e => e.Id)
                .NotEmpty();
        }
    }
}
