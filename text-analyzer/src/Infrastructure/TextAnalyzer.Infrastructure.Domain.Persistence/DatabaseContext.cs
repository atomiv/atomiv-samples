using Microsoft.EntityFrameworkCore;
using TextAnalyzer.Infrastructure.Domain.Persistence.Configurations;
using TextAnalyzer.Infrastructure.Domain.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Persistence.Common
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DocumentRecord> Documents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfiguration(modelBuilder);
            SeedEnum(modelBuilder);
        }

        private void ApplyConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DocumentRecordConfiguration());
        }

        private void SeedEnum(ModelBuilder modelBuilder)
        {
        }
    }
}