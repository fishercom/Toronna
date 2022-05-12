using Toronna.Domain.Entities;
using Toronna.Domain.ValueObjects;
using Toronna.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Toronna.Infrastructure.Context.Repository;

public class LangRepository : IBaseRepository<Lang, GenericId>
{
    private readonly CmsContext _db;

    public LangRepository(CmsContext db)
    {
        _db = db;
    }

    public Lang Add(Lang entity)
    {
        _db.Lang.Add(entity);
        return entity;
    }

    public void Delete(GenericId entityId)
    {
        var item = Find(entityId);
        _db.Lang.Remove(item);
    }

    public Lang Edit(Lang entity)
    {
        var item = Find(entity.Id);
        item.Name = entity.Name;
        item.Slug = entity.Slug;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Lang Find(GenericId entityId)
    {
        var item = _db.Lang.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Lang> List()
    {
        var list = _db.Lang.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
