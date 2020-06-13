using AutoMapper;
using TextAnalyzer.Core.Application.Commands.Customers;
using TextAnalyzer.Core.Domain.Customers;

namespace TextAnalyzer.Infrastructure.Commands.Mapping.Customers
{
    public class DeleteCustomerCommandResponseProfile : Profile
    {
        public DeleteCustomerCommandResponseProfile()
        {
            CreateMap<Customer, DeleteCustomerCommandResponse>();
        }
    }
}