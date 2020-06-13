using Microsoft.AspNetCore.Mvc;
using Optivem.Atomiv.Core.Application;
using System;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Application.Queries.Documents;

namespace TextAnalyzer.Web.RestApi.Controllers
{
    [Route("api/documents")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly IMessageBus _messageBus;

        public DocumentController(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }

        #region Commands

        [HttpPost(Name = "create-document")]
        [ProducesResponseType(422)]
        [ProducesResponseType(typeof(CreateDocumentCommandResponse), 201)]
        public async Task<ActionResult<CreateDocumentCommandResponse>> CreateDocumentAsync(CreateDocumentCommand request)
        {
            var response = await _messageBus.SendAsync(request);
            return CreatedAtRoute("view-document", new { id = response.Id }, response);
        }

        #endregion

        #region Queries

        [HttpGet("{id}", Name = "view-document")]
        [ProducesResponseType(typeof(ViewDocumentQueryResponse), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(422)]
        public async Task<ActionResult<ViewDocumentQueryResponse>> ViewDocumentAsync(Guid id)
        {
            var request = new ViewDocumentQuery { Id = id };
            var response = await _messageBus.SendAsync(request);
            return Ok(response);
        }

        #endregion
    }
}
