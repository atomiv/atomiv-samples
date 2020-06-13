using Optivem.Atomiv.Core.Common.Http;
using TextAnalyzer.Core.Application.Commands.Customers;
using TextAnalyzer.Core.Application.Queries.Customers;
using System.Threading.Tasks;

namespace TextAnalyzer.Web.RestClient.Interface
{
    public interface ICustomerControllerClient : IHttpControllerClient
    {
        #region Commands

        Task<ObjectClientResponse<CreateCustomerCommandResponse>> CreateCustomerAsync(CreateCustomerCommand request, HeaderData header);

        Task<ObjectClientResponse<DeleteCustomerCommandResponse>> DeleteCustomerAsync(DeleteCustomerCommand request, HeaderData header);

        Task<ObjectClientResponse<EditCustomerCommandResponse>> EditCustomerAsync(EditCustomerCommand request, HeaderData header);

        #endregion

        #region Queries

        Task<ObjectClientResponse<BrowseCustomersQueryResponse>> BrowseCustomersAsync(BrowseCustomersQuery request, HeaderData header);

        Task<ObjectClientResponse<FilterCustomersQueryResponse>> FilterCustomersAsync(FilterCustomersQuery request, HeaderData header);

        Task<ObjectClientResponse<ViewCustomerQueryResponse>> ViewCustomerAsync(ViewCustomerQuery request, HeaderData header);

        #endregion
    }
}