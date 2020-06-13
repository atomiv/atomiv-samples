using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Orders;
using TextAnalyzer.Core.Domain.Orders;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Orders
{
    public class EditOrderCommandResponseProfile : Profile
    {
        public EditOrderCommandResponseProfile()
        {
            CreateMap<Order, EditOrderCommandResponse>();

            CreateMap<OrderItem, UpdateOrderItemCommandResponse>();
        }
    }
}
