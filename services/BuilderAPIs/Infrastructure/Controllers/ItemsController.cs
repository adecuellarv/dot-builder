using BuilderAPIs.Domain.Entities;
using BuilderAPIs.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BuilderAPIs.Infrastructure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository _itemsRepository;

        public ItemsController(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public async Task<ActionResult<List<Items>>> GetItems()
        {
            var items = await _itemsRepository.GetItemsAsync();
            return Ok(items);
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Items>> GetItemById(int id)
        {
            var item = await _itemsRepository.GetItemByIdAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] Items item)
        {
            if (item == null)
            {
                return BadRequest("Item cannot be null.");
            }

            var createdItem = await _itemsRepository.AddItemAsync(item);
            return CreatedAtAction(nameof(CreateItem), new { id = createdItem.ItemId }, createdItem);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, [FromBody] Items item)
        {
            if (item == null || id != item.ItemId) return BadRequest();

            var updatedItem = await _itemsRepository.UpdateItemAsync(item);
            if (updatedItem == null) return NotFound();

            return NoContent();
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var deleted = await _itemsRepository.DeleteItemAsync(id);
            if (!deleted) return NotFound();

            return NoContent();
        }
    }
}
