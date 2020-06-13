using Optivem.Atomiv.Core.Application;

namespace TextAnalyzer.Core.Application.Commands.Documents
{
    public class CreateDocumentCommand : IRequest<CreateDocumentCommandResponse>
    {
        public string Name { get; set; }

        public string Text { get; set; }
    }
}
