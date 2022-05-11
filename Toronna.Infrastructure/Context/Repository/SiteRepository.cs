﻿using Toronna.Domain.Entities;
using Toronna.Domain.ValueObjects;
using Toronna.Domain.Interfaces.Repositories;
using Toronna.Infrastructure.Context;

using Ardalis.GuardClauses;

namespace Toronna.Infrastructure.Context.Repository;

public class SiteRepository : IBaseRepository<Site, GenericId>
{
    private readonly CmsContext _db;

    public SiteRepository(CmsContext db)
    {
        _db = db;
    }

    public Site Add(Site entity)
    {
        _db.Site.Add(entity);
        return entity;
    }

    public void Delete(GenericId entityId)
    {
        var item = Find(entityId);
        _db.Site.Remove(item);
    }

    public Site Edit(Site entity)
    {
        var item = Find(entity.Id);
        item.Name = entity.Name;
        item.Url = entity.Url;
        _db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        return item;
    }

    public Site Find(GenericId entityId)
    {
        var item = _db.Site.Where(c => c.Id == entityId).FirstOrDefault();
        Guard.Against.Null(item, nameof(item));

        return item;
    }

    public List<Site> List()
    {
        var list = _db.Site.ToList();

        return list;
    }

    public void SaveAll()
    {
        _db.SaveChanges();
    }
}
