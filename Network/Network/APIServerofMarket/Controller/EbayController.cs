using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Warehouse;
using Warehouse.Model;

namespace APIServerofMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EbayController : ControllerBase
    {
        private readonly MCommodityDataContextDataContext _context;

        public EbayController(MCommodityDataContextDataContext context)
        {
            _context = context;
        }

        // GET: api/Ebays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ebay>> GetEbay(int id)
        {
            var Ebay = await _context.Ebays.FindAsync(id);

            if (Ebay == null)
            {
                return NotFound();
            }

            return Ebay;
        }

        // PUT: api/Ebays/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEbay(int id, Ebay Ebay)
        {
            if (id != Ebay.Id)
            {
                return BadRequest();
            }

            _context.Entry(Ebay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EbayExists(id))
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

        private bool EbayExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Ebays
        [HttpPost]
        public async Task<ActionResult<Ebay>> PostEbay(Ebay Ebay)
        {
            _context.Ebays.Add(Ebay);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetEbay", new { id = Ebay.Id }, Ebay);
            return CreatedAtAction(nameof(GetEbay), new { id = Ebay.Id }, Ebay);
        }

        // DELETE: api/Ebays/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEbay(int id)
        {
            var Ebay = await _context.Ebays.FindAsync(id);
            if (Ebay == null)
            {
                return NotFound();
            }

            _context.Ebays.Remove(Ebay);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}