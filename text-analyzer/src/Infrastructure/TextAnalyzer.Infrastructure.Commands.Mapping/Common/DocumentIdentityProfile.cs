using AutoMapper;
using System;
using TextAnalyzer.Core.Domain.Documents;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Common
{
    public class DocumentIdentityProfile : Profile
    {
        public DocumentIdentityProfile()
        {
            CreateMap<DocumentIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}
