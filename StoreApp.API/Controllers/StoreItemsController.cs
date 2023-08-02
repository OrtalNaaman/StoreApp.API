using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.API.Data;
using StoreApp.API.Entities;

namespace StoreApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StoreItemsController : ControllerBase
    {
        private readonly StoreDbContext _context;

        public StoreItemsController(StoreDbContext context)
        {
            _context = context;
        }

        // GET: api/StoreItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StoreItem>>> GetStoreItems()
        {
          if (_context.StoreItems == null)
          {
              return NotFound();
          }
            return await _context.StoreItems.ToListAsync();
        }

        // GET: api/StoreItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreItem>> GetStoreItem(int id)
        {
          if (_context.StoreItems == null)
          {
              return NotFound();
          }
            var storeItem = await _context.StoreItems.FindAsync(id);

            if (storeItem == null)
            {
                return NotFound();
            }

            return storeItem;
        }

        // PUT: api/StoreItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutStoreItem(int id, StoreItem storeItem)
        {
            if (id != storeItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(storeItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StoreItemExists(id))
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

        // POST: api/StoreItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<StoreItem>> PostStoreItem(StoreItem storeItem)
        {
          if (_context.StoreItems == null)
          {
              return Problem("Entity set 'StoreDbContext.StoreItems'  is null.");
          }
            _context.StoreItems.Add(storeItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStoreItem", new { id = storeItem.Id }, storeItem);
        }

        // DELETE: api/StoreItems/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteStoreItem(int id)
        {
            if (_context.StoreItems == null)
            {
                return NotFound();
            }
            var storeItem = await _context.StoreItems.FindAsync(id);
            if (storeItem == null)
            {
                return NotFound();
            }

            _context.StoreItems.Remove(storeItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StoreItemExists(int id)
        {
            return (_context.StoreItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
