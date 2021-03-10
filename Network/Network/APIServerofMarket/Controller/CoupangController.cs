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
    public class CoupangController : ControllerBase
    {
        private readonly MCommodityDataContext _context;

        public CoupangController(MCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/Coupangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coupang>> GetCoupang(int id)
        {
            var Coupang = await _context.Coupangs.FindAsync(id);

            if (Coupang == null)
            {
                return NotFound();
            }

            return Coupang;
        }

        // PUT: api/Coupangs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCoupang(int id, Coupang Coupang)
        {
            if (id != Coupang.Id)
            {
                return BadRequest();
            }

            _context.Entry(Coupang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoupangExists(id))
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

        private bool CoupangExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Coupangs
        [HttpPost]
        public async Task<ActionResult<Coupang>> PostCoupang(Coupang Coupang)
        {
            _context.Coupangs.Add(Coupang);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetCoupang", new { id = Coupang.Id }, Coupang);
            return CreatedAtAction(nameof(GetCoupang), new { id = Coupang.Id }, Coupang);
        }

        // DELETE: api/Coupangs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoupang(int id)
        {
            var Coupang = await _context.Coupangs.FindAsync(id);
            if (Coupang == null)
            {
                return NotFound();
            }

            _context.Coupangs.Remove(Coupang);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}