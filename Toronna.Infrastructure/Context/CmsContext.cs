using Toronna.Domain.Entities;
using Toronna.Infrastructure.Config;

using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

namespace Toronna.Infrastructure.Context;

public class CmsContext : DbContext
{
    public DbSet<Site> Site { set; get; }
    public DbSet<Form> Form { set; get; }
    public DbSet<Schema> Schema { set; get; }
    public DbSet<Field> Field { set; get; }
    public DbSet<Lang> Lang { set; get; }
    public DbSet<Post> Post { set; get; }
    public DbSet<PostMeta> PostMeta { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySQL("server=localhost;database=toronna;user=root;password=asixon");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new SiteConfig());
        builder.ApplyConfiguration(new FormConfig());
        builder.ApplyConfiguration(new SchemaConfig());
        builder.ApplyConfiguration(new FieldConfig());
        builder.ApplyConfiguration(new LangConfig());
        builder.ApplyConfiguration(new PostConfig());
        builder.ApplyConfiguration(new PostMetaConfig());
    }
}
