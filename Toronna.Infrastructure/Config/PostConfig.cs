using Toronna.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Toronna.Infrastructure.Config;

public class PostConfig : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(c => c.SchemaId);
        builder.HasKey(c => c.ParentId);

        builder.Property(p => p.Title)
            .HasMaxLength(255)
            .IsRequired();
        builder.Property(p => p.Slug)
            .HasMaxLength(512)
            .IsRequired();
    }
}

