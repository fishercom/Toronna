using Toronna.Domain.Entities;
using Toronna.Domain.ValueObjects;
using Toronna.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Toronna.Infrastructure.Context.Repository;

public class PostRepository : IBaseRepository<Post, GenericId>
{
    private readonly CmsContext _db;

    public PostRepository(CmsContext db)
    {
        _db = db;
    }

    public Post Add(Post entity)
    {
        _db.Post.Add(entity);
        return entity;
    }

    public void Delete(GenericId entityId)
    {
        var item = Find(entityId);
        _db.Post.Remove(item);
    }

    public Post Edit(Post entity)
    {
        var item = Find(entity.Id);
        item.SchemaId = entity.SchemaId;
        item.LangId = entity.LangId;
        item.ParentId = entity.ParentId;
        item.Title = entity.Title;
        item.Content = entity.Content;
        item.Slug = entity.Slug;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Post Find(GenericId entityId)
    {
        var item = _db.Post.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Post> List()
    {
        var list = _db.Post.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
