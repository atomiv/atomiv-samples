using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyzer.Infrastructure.Domain.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Domain.Persistence.Configurations
{
    public class DocumentRecordConfiguration : IEntityTypeConfiguration<DocumentRecord>
    {
        public void Configure(EntityTypeBuilder<DocumentRecord> builder)
        {
            builder.Property(e => e.Id)
                .ValueGeneratedNever();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(2000);
        }
    }
}
