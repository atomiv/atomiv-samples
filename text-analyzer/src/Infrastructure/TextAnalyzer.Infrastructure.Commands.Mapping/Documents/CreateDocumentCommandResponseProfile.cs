using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Domain.Documents;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Documents
{
    public class CreateDocumentCommandResponseProfile : Profile
    {
        public CreateDocumentCommandResponseProfile()
        {
            CreateMap<Document, CreateDocumentCommandResponse>()
                .ForMember(dest => dest.WordCount, opt => opt.MapFrom(e => e.GetWordCount()));
        }
    }
}
