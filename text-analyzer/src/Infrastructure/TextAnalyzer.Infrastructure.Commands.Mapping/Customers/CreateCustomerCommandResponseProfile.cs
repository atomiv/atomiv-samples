using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Customers;
using TextAnalyzer.Core.Domain.Customers;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Customers
{
    public class CreateCustomerCommandResponseProfile : Profile
    {
        public CreateCustomerCommandResponseProfile()
        {
            CreateMap<Customer, CreateCustomerCommandResponse>();
        }
    }
}
