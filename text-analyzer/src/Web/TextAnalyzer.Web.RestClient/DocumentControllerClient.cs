using Optivem.Atomiv.Core.Common.Http;
using Optivem.Atomiv.Core.Common.Serialization;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Application.Queries.Documents;
using TextAnalyzer.Web.RestClient.Interface;

namespace TextAnalyzer.Web.RestClient
{
    public class DocumentControllerClient : BaseJsonControllerClient, IDocumentControllerClient
    {
        public DocumentControllerClient(HttpClient httpClient, IJsonSerializer jsonSerializer) 
            : base(httpClient, jsonSerializer, "api/documents")
        {
        }

        public Task<ObjectClientResponse<CreateDocumentCommandResponse>> CreateDocumentAsync(CreateDocumentCommand request)
        {
            return Client.PostAsync<CreateDocumentCommand, CreateDocumentCommandResponse>(request, new HeaderDictionary());
        }

        public Task<ObjectClientResponse<ViewDocumentQueryResponse>> ViewDocumentAsync(ViewDocumentQuery request)
        {
            var id = request.Id;
            return Client.GetByIdAsync<Guid, ViewDocumentQueryResponse>(id);
        }
    }
}
