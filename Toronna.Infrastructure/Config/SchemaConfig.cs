using Toronna.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Toronna.Infrastructure.Config;

public class SchemaConfig : IEntityTypeConfiguration<Schema>
{
    public void Configure(EntityTypeBuilder<Schema> builder)
    {
        builder.HasKey(c => c.ParentId);
        builder.HasKey(c => c.SiteId);

        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(p => p.Slug)
            .HasMaxLength(100)
            .IsRequired();

        builder
            .HasMany(c=>c.Posts)
            .WithOne(c=>c.Schema);
    }
}

