using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TextAnalyzer.Infrastructure.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Persistence.Configurations
{
    public class OrderStatusRecordConfiguration : IEntityTypeConfiguration<OrderStatusRecord>
    {
        public void Configure(EntityTypeBuilder<OrderStatusRecord> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedNever();

            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}