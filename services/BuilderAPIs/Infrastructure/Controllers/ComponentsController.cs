using BuilderAPIs.Domain.Entities;
using BuilderAPIs.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuilderAPIs.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentsController : ControllerBase
    {
        private readonly IComponentsRepository _componentsRepository;

        public ComponentsController(IComponentsRepository componentsRepository)
        {
            _componentsRepository = componentsRepository;
        }
        // GET: api/<ComponentsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ComponentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Items>> GetComponentsById(string id)
        {
            var items = await _componentsRepository.GetComponentByIdAsync(int.Parse(id));
            if (items == null || !items.Any()) return NotFound();
            return Ok(items);
        }

        // POST api/<ComponentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ComponentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ComponentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
