using Toronna.Domain.Entities;
using Toronna.Domain.ValueObjects;
using Toronna.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Toronna.Infrastructure.Context.Repository;

public class PostMetaRepository : IBaseRepository<PostMeta, GenericId>
{
    private readonly CmsContext _db;

    public PostMetaRepository(CmsContext db)
    {
        _db = db;
    }

    public PostMeta Add(PostMeta entity)
    {
        _db.PostMeta.Add(entity);
        return entity;
    }

    public void Delete(GenericId entityId)
    {
        var item = Find(entityId);
        _db.PostMeta.Remove(item);
    }

    public PostMeta Edit(PostMeta entity)
    {
        var item = Find(entity.Id);
        item.PostId = entity.PostId;
        item.FieldId = entity.FieldId;
        item.Value = entity.Value;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public PostMeta Find(GenericId entityId)
    {
        var item = _db.PostMeta.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<PostMeta> List()
    {
        var list = _db.PostMeta.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
