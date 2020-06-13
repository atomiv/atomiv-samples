using Optivem.Atomiv.Core.Application;
using Optivem.Atomiv.Core.Domain;
using System.Threading.Tasks;
using TextAnalyzer.Core.Application.Commands.Documents;
using TextAnalyzer.Core.Domain.Documents;

namespace TextAnalyzer.Core.Application.Commands.Handlers.Documents
{
    public class CreateDocumentCommandHandler : IRequestHandler<CreateDocumentCommand, CreateDocumentCommandResponse>
    {
        private readonly IDocumentFactory _documentFactory;
        private readonly IDocumentRepository _documentRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateDocumentCommandHandler(IDocumentFactory bookFactory, 
            IDocumentRepository bookRepository, 
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _documentFactory = bookFactory;
            _documentRepository = bookRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CreateDocumentCommandResponse> HandleAsync(CreateDocumentCommand request)
        {
            var name = request.Name;
            var text = request.Text;

            var document = _documentFactory.Create(name, text);
            _documentRepository.AddDocument(document);

            await _unitOfWork.SaveChangesAsync();

            return _mapper.Map<Document, CreateDocumentCommandResponse>(document);
        }
    }
}
