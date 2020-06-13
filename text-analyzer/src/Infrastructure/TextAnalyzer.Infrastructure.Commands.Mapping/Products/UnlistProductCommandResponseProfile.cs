using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Products;
using TextAnalyzer.Core.Domain.Products;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Products
{
    public class UnlistProductCommandResponseProfile : Profile
    {
        public UnlistProductCommandResponseProfile()
        {
            CreateMap<Product, UnlistProductCommandResponse>();
        }
    }
}
