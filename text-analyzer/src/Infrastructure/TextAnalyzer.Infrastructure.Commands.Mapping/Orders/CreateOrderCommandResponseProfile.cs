using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Orders;
using TextAnalyzer.Core.Domain.Orders;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Orders
{
    public class CreateOrderCommandResponseProfile : Profile
    {
        public CreateOrderCommandResponseProfile()
        {
            CreateMap<Order, CreateOrderCommandResponse>();

            CreateMap<OrderItem, CreateOrderItemResponse>();
        }
    }
}
