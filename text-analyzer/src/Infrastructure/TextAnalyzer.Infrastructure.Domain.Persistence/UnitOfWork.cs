using Optivem.Atomiv.Core.Domain;
using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;

namespace TextAnalyzer.Infrastructure.Persistence.Common
{
    public class UnitOfWork : UnitOfWork<DatabaseContext>, IUnitOfWork
    {
        public UnitOfWork(DatabaseContext context, bool disposeContext = false)
            : base(context, disposeContext)
        {
        }
    }
}