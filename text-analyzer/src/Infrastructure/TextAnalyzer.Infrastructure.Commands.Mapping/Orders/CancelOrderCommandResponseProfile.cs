using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Orders;
using TextAnalyzer.Core.Domain.Orders;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Orders
{
    public class CancelOrderCommandResponseProfile : Profile
    {
        public CancelOrderCommandResponseProfile()
        {
            CreateMap<Order, CancelOrderCommandResponse>();
        }
    }
}
