using Optivem.Atomiv.Infrastructure.EntityFrameworkCore;
using TextAnalyzer.Infrastructure.Persistence.Common;

namespace TextAnalyzer.Infrastructure.Domain.Repositories
{
    public class Repository : Repository<DatabaseContext>
    {
        public Repository(DatabaseContext context) : base(context)
        {
        }
    }
}
