using System;
using Ardalis.GuardClauses;
using Toronna.Application.Interfaces;
using Toronna.Domain.Entities;
using Toronna.Domain.Interfaces.Repositories;
using Toronna.Domain.ValueObjects;

namespace Toronna.Application.Services;

public class ArticleService : IBaseService<Article, GenericId>
{
    private readonly IBaseRepository<Article, GenericId> repArticle;
    public ArticleService(
        IBaseRepository<Article, GenericId> _repArticle
        )
    {
        repArticle = _repArticle;
    }

    public Article Add(Article entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Article results = repArticle.Add(entity);

        repArticle.SaveAll();

        return results;
    }

    public Article Edit(Article entity)
    {
        Guard.Against.Null(entity, nameof(entity));

        Article results = repArticle.Edit(entity);
        repArticle.SaveAll();

        return results;
    }

    public void Delete(GenericId entityId)
    {
        repArticle.Delete(entityId);
        repArticle.SaveAll();
    }

    public Article Find(GenericId entityId)
    {
        return repArticle.Find(entityId);
    }

    public List<Article> List()
    {
        return repArticle.List();
    }

}

