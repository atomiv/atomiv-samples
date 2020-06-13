using AutoMapper;
using TextAnalyzer.Core.Domain.Orders;
using System;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Common
{
    public class OrderIdentityProfile : Profile
    {
        public OrderIdentityProfile()
        {
            CreateMap<OrderIdentity, Guid>()
                .ConvertUsing(src => src.Value);

            CreateMap<OrderItemIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}