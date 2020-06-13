using Optivem.Atomiv.Core.Application;
using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;
using TextAnalyzer.Infrastructure.Persistence.Common;

namespace TextAnalyzer.Infrastructure.Queries.Handlers
{
    public abstract class QueryHandler<TRequest, TResponse> : QueryHandler<DatabaseContext, TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        public QueryHandler(DatabaseContext context) : base(context)
        {
        }
    }
}
