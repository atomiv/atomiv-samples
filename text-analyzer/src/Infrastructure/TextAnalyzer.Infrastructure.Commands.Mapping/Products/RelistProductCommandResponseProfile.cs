using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Products;
using TextAnalyzer.Core.Domain.Products;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Products
{
    public class RelistProductCommandResponseProfile : Profile
    {
        public RelistProductCommandResponseProfile()
        {
            CreateMap<Product, RelistProductCommandResponse>();
        }
    }
}
