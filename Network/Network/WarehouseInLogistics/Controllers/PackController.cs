using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Warehouse;
using Warehouse.Model;

namespace WarehouseInLogistics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackController : ControllerBase
    {
        private readonly WarehouseDataContext _context;

        public PackController(WarehouseDataContext context)
        {
            _context = context;
        }

        // GET: api/Packs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pack>> GetPack(int id)
        {
            var Pack = await _context.Packs.FindAsync(id);

            if (Pack == null)
            {
                return NotFound();
            }

            return Pack;
        }

        // PUT: api/Packs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPack(int id, Pack Pack)
        {
            if (id != Pack.Id)
            {
                return BadRequest();
            }

            _context.Entry(Pack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackExists(id))
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

        private bool PackExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Packs
        [HttpPost]
        public async Task<ActionResult<Pack>> PostPack(Pack Pack)
        {
            _context.Packs.Add(Pack);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetPack", new { id = Pack.Id }, Pack);
            return CreatedAtAction(nameof(GetPack), new { id = Pack.Id }, Pack);
        }

        // DELETE: api/Packs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePack(int id)
        {
            var Pack = await _context.Packs.FindAsync(id);
            if (Pack == null)
            {
                return NotFound();
            }

            _context.Packs.Remove(Pack);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}