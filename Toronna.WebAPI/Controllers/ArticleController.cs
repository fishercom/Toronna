using Microsoft.AspNetCore.Mvc;

using Toronna.Domain.Entities;
using Toronna.Application.Services;
using Toronna.Infrastructure.Context;
using Toronna.Infrastructure.Context.Repository;
using Toronna.Domain.ValueObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toronna.WebAPI.Controllers;

[Route("api/[controller]")]
public class ArticleController : Controller
{
    ArticleService CreateService()
    {
        CmsContext db = new CmsContext();
        ArticleRepository repArticle = new ArticleRepository(db);
        ArticleService service = new ArticleService(repArticle);
        return service;
    }


    // GET: api/values
    [HttpGet]
    public ActionResult<List<Article>> Get()
    {
        var service = CreateService();
        return Ok(service.List());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Article> Get(GenericId id)
    {
        var service = CreateService();
        return Ok(service.Find(id));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] Article article)
    {
        var service = CreateService();
        service.Add(article);
        return Ok("Added Successfully!");
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult Put(GenericId id, [FromBody] Article article)
    {
        var service = CreateService();
        article.Id = id;
        service.Edit(article);
        return Ok("Updated Successfully!");
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(GenericId id)
    {
        var service = CreateService();
        service.Delete(id);
        return Ok("Deleted Successfully!");
    }
}

