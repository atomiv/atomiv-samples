using Optivem.Atomiv.Core.Common.Http;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Application.Queries.Documents;

namespace TextAnalyzer.Web.RestClient.Interface
{
    public interface IDocumentControllerClient
    {
        #region Commands

        Task<ObjectClientResponse<CreateDocumentCommandResponse>> CreateDocumentAsync(CreateDocumentCommand request);

        #endregion

        #region Queries

        Task<ObjectClientResponse<ViewDocumentQueryResponse>> ViewDocumentAsync(ViewDocumentQuery request);

        #endregion
    }
}
