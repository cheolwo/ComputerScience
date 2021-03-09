using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Warehouse;
using Warehouse.Model;

namespace APIServerofLogisticsCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomingTagController : ControllerBase
    {
        private readonly WarehouseDataContext _context;

        public IncomingTagController(WarehouseDataContext context)
        {
            _context = context;
        }

        // GET: api/IncomingTags/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IncomingTag>> GetIncomingTag(int id)
        {
            var IncomingTag = await _context.IncomingTags.FindAsync(id);

            if (IncomingTag == null)
            {
                return NotFound();
            }

            return IncomingTag;
        }

        // PUT: api/IncomingTags/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomingTag(int id, IncomingTag IncomingTag)
        {
            if (id != IncomingTag.Id)
            {
                return BadRequest();
            }

            _context.Entry(IncomingTag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomingTagExists(id))
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

        // POST: api/IncomingTags
        [HttpPost]
        public async Task<ActionResult<IncomingTag>> PostIncomingTag(IncomingTag IncomingTag)
        {
            _context.IncomingTags.Add(IncomingTag);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetIncomingTag", new { id = IncomingTag.Id }, IncomingTag);
            return CreatedAtAction(nameof(GetIncomingTag), new { id = IncomingTag.Id }, IncomingTag);
        }

        // DELETE: api/IncomingTags/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncomingTag(int id)
        {
            var IncomingTag = await _context.IncomingTags.FindAsync(id);
            if (IncomingTag == null)
            {
                return NotFound();
            }

            _context.IncomingTags.Remove(IncomingTag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}