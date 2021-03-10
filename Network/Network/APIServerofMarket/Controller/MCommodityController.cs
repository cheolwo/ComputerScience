using Market;
using Market.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace APIServerofMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCommodityController : ControllerBase
    {
        private readonly MCommodityDataContext _context;

        public MCommodityController(MCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/MCommodities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MCommodity>> GetMCommodity(int id)
        {
            var MCommodity = await _context.MCommodities.FindAsync(id);

            if (MCommodity == null)
            {
                return NotFound();
            }

            return MCommodity;
        }

        // PUT: api/MCommodities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMCommodity(int id, MCommodity MCommodity)
        {
            if (id != MCommodity.Id)
            {
                return BadRequest();
            }

            _context.Entry(MCommodity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MCommodityExists(id))
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

        private bool MCommodityExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/MCommodities
        [HttpPost]
        public async Task<ActionResult<MCommodity>> PostMCommodity(MCommodity MCommodity)
        {
            _context.MCommodities.Add(MCommodity);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetMCommodity", new { id = MCommodity.Id }, MCommodity);
            return CreatedAtAction(nameof(GetMCommodity), new { id = MCommodity.Id }, MCommodity);
        }

        // DELETE: api/MCommodities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMCommodity(int id)
        {
            var MCommodity = await _context.MCommodities.FindAsync(id);
            if (MCommodity == null)
            {
                return NotFound();
            }

            _context.MCommodities.Remove(MCommodity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}