using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LogicStoreAPI.Data;
using LogicStoreAPI.Models;

namespace LogicStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPicturesController : ControllerBase
    {
        private readonly DataContext _context;

        public ItemPicturesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/ItemPictures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPicture>>> GetItemPictures()
        {
          if (_context.ItemPictures == null)
          {
              return NotFound();
          }
            return await _context.ItemPictures.ToListAsync();
        }

        // GET: api/ItemPictures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemPicture>> GetItemPicture(int id)
        {
          if (_context.ItemPictures == null)
          {
              return NotFound();
          }
            var itemPicture = await _context.ItemPictures.FindAsync(id);

            if (itemPicture == null)
            {
                return NotFound();
            }

            return itemPicture;
        }

        // PUT: api/ItemPictures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemPicture(int id, ItemPicture itemPicture)
        {
            if (id != itemPicture.PictureId)
            {
                return BadRequest();
            }

            _context.Entry(itemPicture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemPictureExists(id))
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

        // POST: api/ItemPictures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ItemPicture>> PostItemPicture(ItemPicture itemPicture)
        {
          if (_context.ItemPictures == null)
          {
              return Problem("Entity set 'DataContext.ItemPictures'  is null.");
          }
            _context.ItemPictures.Add(itemPicture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemPicture", new { id = itemPicture.PictureId }, itemPicture);
        }

        // DELETE: api/ItemPictures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemPicture(int id)
        {
            if (_context.ItemPictures == null)
            {
                return NotFound();
            }
            var itemPicture = await _context.ItemPictures.FindAsync(id);
            if (itemPicture == null)
            {
                return NotFound();
            }

            _context.ItemPictures.Remove(itemPicture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemPictureExists(int id)
        {
            return (_context.ItemPictures?.Any(e => e.PictureId == id)).GetValueOrDefault();
        }
    }
}
