using AutoMapper;
using TextAnalyzer.Core.Domain.Customers;
using System;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Common
{
    public class CustomerIdentityProfile : Profile
    {
        public CustomerIdentityProfile()
        {
            CreateMap<CustomerIdentity, Guid>()
                .ConvertUsing(src => src.Value);
        }
    }
}