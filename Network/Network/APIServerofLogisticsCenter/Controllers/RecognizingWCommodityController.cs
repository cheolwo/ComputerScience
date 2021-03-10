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
        private readonly WCommodityDataContext _WContext;
        private readonly TCommodityDataContext _TContext;

        public WCommodityController(WCommodityDataContext WContext, TCommodityDataContext TContext)
        {
            _WContext = WContext;
            _TContext = TContext;
        }

        // GET: api/WCommodities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecognizingWCommodity>> GetRecognizingWCommodity(int id)
        {
            var RecognizingWCommodity = await _WContext.WCommodities.FindAsync(id);

            if (RecognizingWCommodity == null)
            {
                return NotFound();
            }

            return RecognizingWCommodity;
        }

        // PUT: api/WCommodities/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecognizingWCommodity(int id, RecognizingWCommodity RecognizingWCommodity)
        {
            if (id != RecognizingWCommodity.Id)
            {
                return BadRequest();
            }

            _WContext.Entry(RecognizingWCommodity).State = EntityState.Modified;

            try
            {
                await _WContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecognizingWCommodityExists(id))
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

        private bool RecognizingWCommodityExists(int id)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/WCommodities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecognizingWCommodity(int id)
        {
            var RecognizingWCommodity = await _WContext.WCommodities.FindAsync(id);
            if (RecognizingWCommodity == null)
            {
                return NotFound();
            }

            _WContext.WCommodities.Remove(RecognizingWCommodity);
            await _WContext.SaveChangesAsync();

            return NoContent();
        }
    }
}