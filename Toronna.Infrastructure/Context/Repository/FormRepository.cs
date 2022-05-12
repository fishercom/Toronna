using Toronna.Domain.Entities;
using Toronna.Domain.ValueObjects;
using Toronna.Domain.Interfaces.Repositories;

using Ardalis.GuardClauses;

namespace Toronna.Infrastructure.Context.Repository;

public class FormRepository : IBaseRepository<Form, GenericId>
{
    private readonly CmsContext _db;

    public FormRepository(CmsContext db)
    {
        _db = db;
    }

    public Form Add(Form entity)
    {
        _db.Form.Add(entity);
        return entity;
    }

    public void Delete(GenericId entityId)
    {
        var item = Find(entityId);
        _db.Form.Remove(item);
    }

    public Form Edit(Form entity)
    {
        var item = Find(entity.Id);
        item.SiteId = entity.SiteId;
        item.Name = entity.Name;
        item.Slug = entity.Slug;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Form Find(GenericId entityId)
    {
        var item = _db.Form.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Form> List()
    {
        var list = _db.Form.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
