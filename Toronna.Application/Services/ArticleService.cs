using System;
using Ardalis.GuardClauses;
using Toronna.Application.Interfaces;
using Toronna.Domain.Entities;
using Toronna.Domain.Interfaces.Repositories;

namespace Toronna.Application.Services;

public class ArticleService : IBaseService<Article, Guid>
{
    private readonly IBaseRepository<Article, Guid> repArticle;
    public ArticleService(
        IBaseRepository<Article, Guid> _repArticle
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

    public void Delete(Guid entityId)
    {
        repArticle.Delete(entityId);
        repArticle.SaveAll();
    }

    public Article Find(Guid entityId)
    {
        return repArticle.Find(entityId);
    }

    public List<Article> List()
    {
        return repArticle.List();
    }

}

