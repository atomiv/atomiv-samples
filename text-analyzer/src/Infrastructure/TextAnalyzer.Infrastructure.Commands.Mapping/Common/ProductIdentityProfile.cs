using AutoMapper;
using TextAnalyzer.Core.Domain.Products;
using System;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Common
{
    public class ProductIdentityProfile : Profile
    {
        public ProductIdentityProfile()
        {
            CreateMap<ProductIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}