using Microsoft.AspNetCore.Mvc;

using Toronna.Domain;
using Toronna.Application.Services;
using Toronna.Infrastructure.Context;
using Toronna.Infrastructure.Context.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Toronna.WebAPI.Controllers;

[Route("api/[controller]")]
public class SchemaController : Controller
{
    SchemaService CreateService()
    {
        CmsContext db = new CmsContext();
        SchemaRepository repSchema = new SchemaRepository(db);
        FieldRepository repField = new FieldRepository(db);
        SchemaService service = new SchemaService(repSchema, repField);
        return service;
    }


    // GET: api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}

