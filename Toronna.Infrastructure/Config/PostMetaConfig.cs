using Toronna.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Toronna.Infrastructure.Config;

public class PostMetaConfig : IEntityTypeConfiguration<PostMeta>
{
    public void Configure(EntityTypeBuilder<PostMeta> builder)
    {
        builder.HasKey(c => c.PostId);
        builder.HasKey(c => c.FieldId);

        builder.Property(p => p.Value)
            .HasMaxLength(100)
            .IsRequired();
    }
}

