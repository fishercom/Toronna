using Toronna.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Toronna.Infrastructure.Config;

public class SchemaConfig : IEntityTypeConfiguration<Schema>
{
    public void Configure(EntityTypeBuilder<Schema> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
    }
}

