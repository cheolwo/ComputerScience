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
    public class IndependentMallController : ControllerBase
    {
        private readonly MCommodityDataContextDataContext _context;

        public IndependentMallController(MCommodityDataContextDataContext context)
        {
            _context = context;
        }

        // GET: api/IndependentMalls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IndependentMall>> GetIndependentMall(int id)
        {
            var IndependentMall = await _context.IndependentMalls.FindAsync(id);

            if (IndependentMall == null)
            {
                return NotFound();
            }

            return IndependentMall;
        }

        // PUT: api/IndependentMalls/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIndependentMall(int id, IndependentMall IndependentMall)
        {
            if (id != IndependentMall.Id)
            {
                return BadRequest();
            }

            _context.Entry(IndependentMall).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndependentMallExists(id))
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

        private bool IndependentMallExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/IndependentMalls
        [HttpPost]
        public async Task<ActionResult<IndependentMall>> PostIndependentMall(IndependentMall IndependentMall)
        {
            _context.IndependentMalls.Add(IndependentMall);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetIndependentMall", new { id = IndependentMall.Id }, IndependentMall);
            return CreatedAtAction(nameof(GetIndependentMall), new { id = IndependentMall.Id }, IndependentMall);
        }

        // DELETE: api/IndependentMalls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIndependentMall(int id)
        {
            var IndependentMall = await _context.IndependentMalls.FindAsync(id);
            if (IndependentMall == null)
            {
                return NotFound();
            }

            _context.IndependentMalls.Remove(IndependentMall);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}