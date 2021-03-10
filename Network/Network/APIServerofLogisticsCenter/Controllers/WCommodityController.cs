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
    public class WCommodityController : ControllerBase
    {
        private readonly WCommodityDataContext _context;

        public WCommodityController(WCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/WCommodities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WCommodity>> GetWCommodity(int id)
        {
            var WCommodity = await _context.WCommodities.FindAsync(id);

            if (WCommodity == null)
            {
                return NotFound();
            }

            return WCommodity;
        }

        // GET: api/WCommodities/5
        [HttpGet("{barcode}")]
        public async Task<ActionResult<List<WCommodity>>> GetWCommodity(string barcode)
        {
            var WCommodies = await _context.WCommodities.Where(u => u.Barcode.Equals(barcode)).ToListAsync();

            if (WCommodies.Count.Equals(0))
            {
                return NotFound();
            }

            return WCommodies;
        }

        // PUT: api/WCommodities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWCommodity(int id, WCommodity WCommodity)
        {
            if (id != WCommodity.Id)
            {
                return BadRequest();
            }

            _context.Entry(WCommodity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WCommodityExists(id))
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

        private bool WCommodityExists(int id)
        {
            var WCommodity = _context.WCommodities.Find(id);
            if(WCommodity != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // POST: api/WCommodities
        [HttpPost]
        public async Task<ActionResult> PostWCommodity(RecognizingWCommodity RecognizingWCommodity)
        {
                foreach (var TCommodity in RecognizingWCommodity.CrossDockingCommodityofSeller)
                {                   
                    var WCommodity = new WCommodity {TCommodityId = Tcommodity.Id, Purpose = "CrossDocking"}
                    await PostWCommodity(WCommodity);
                }
                foreach (var TCommodity in RecognizingWCommodity.CodeofCrossDockingBaseForBuyer)
                {
                    var WCommodity = new WCommodity {TCommodityId = Tcommodity.Id, Purpose = "CrossDocking"}
                    await PostWCommodity(WCommodity);
                }
                foreach (var Tcommodity in RecognizingWCommodity.LogisticsAgencyCommodityofBuyer)
                {
                    var WCommodity = new WCommodity {TCommodityId = Tcommodity.Id, Purpose = "LogisticsAency"}
                    await PostWCommodity(WCommodity);
                }

            //return CreatedAtAction("GetWCommodity", new { id = WCommodity.Id }, WCommodity);
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<WCommodity>> PostWCommodity(WCommodity WCommodity)
        {
            _context.WCommodities.Add(WCommodity);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetWCommodity", new { id = WCommodity.Id }, WCommodity);
            return CreatedAtAction(nameof(GetWCommodity), new { id = WCommodity.Id }, WCommodity);
        }

        // DELETE: api/WCommodities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWCommodity(int id)
        {
            var WCommodity = await _context.WCommodities.FindAsync(id);
            if (WCommodity == null)
            {
                return NotFound();
            }

            _context.WCommodities.Remove(WCommodity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}