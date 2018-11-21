using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadMyLife.Models;

namespace ReadMyLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly ReadMyLifeContext _context;

        public StoryController(ReadMyLifeContext context)
        {
            _context = context;
        }

        // GET: api/Story
        [HttpGet]
        public IEnumerable<StoryItem> GetStoryItem()
        {
            return _context.StoryItem;
        }

        // GET: api/Story/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStoryItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var storyItem = await _context.StoryItem.FindAsync(id);

            if (storyItem == null)
            {
                return NotFound();
            }

            return Ok(storyItem);
        }

        // GET: api/Story/Tag
        [HttpGet("tag/{tag}")]
        public async Task<List<StoryItem>> GetStoryItem([FromRoute] string tag)
        {
            var stories = (from s in _context.StoryItem where s.Tag.Equals(tag) select s);

            var returned = await stories.ToListAsync();
            return returned;
        }

        // PUT: api/Story/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStoryItem([FromRoute] int id, [FromBody] StoryItem storyItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != storyItem.StoryID)
            {
                return BadRequest();
            }

            _context.Entry(storyItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoryItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Story
        [HttpPost]
        public async Task<IActionResult> PostStoryItem([FromBody] StoryItem storyItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.StoryItem.Add(storyItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoryItem", new { id = storyItem.StoryID }, storyItem);
        }

        // DELETE: api/Story/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStoryItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var storyItem = await _context.StoryItem.FindAsync(id);
            if (storyItem == null)
            {
                return NotFound();
            }

            _context.StoryItem.Remove(storyItem);
            await _context.SaveChangesAsync();

            return Ok(storyItem);
        }

        private bool StoryItemExists(int id)
        {
            return _context.StoryItem.Any(e => e.StoryID == id);
        }

        private bool StoryItemExists(string tag)
        {
            return _context.StoryItem.Any(e => e.Tag == tag);
        }
    }
}