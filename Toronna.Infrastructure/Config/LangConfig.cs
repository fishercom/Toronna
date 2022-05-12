using Toronna.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Toronna.Infrastructure.Config;

public class LangConfig : IEntityTypeConfiguration<Lang>
{
    public void Configure(EntityTypeBuilder<Lang> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(p => p.Slug)
            .HasMaxLength(100)
            .IsRequired();
    }
}

