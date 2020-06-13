using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TextAnalyzer.Infrastructure.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Persistence.Configurations
{
    public class CustomerRecordConfiguration : IEntityTypeConfiguration<CustomerRecord>
    {
        public void Configure(EntityTypeBuilder<CustomerRecord> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedNever();

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}