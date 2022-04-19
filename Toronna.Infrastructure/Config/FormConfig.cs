using Toronna.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Toronna.Infrastructure.Config;

public class FormConfig : IEntityTypeConfiguration<Form>
{
    public void Configure(EntityTypeBuilder<Form> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired();
    }
}

