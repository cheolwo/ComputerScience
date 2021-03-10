using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Warehouse;
using Warehouse.Model;

namespace APIServerofLogisticsCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly WCommodityDataContext _WCommodityDataContext;
        private readonly IHttpContextAccessor _httpcontextAccessor;

        public BaseController(IHttpContextAccessor httpContextAccessor, WCommodityDataContext context)
        {
            _WCommodityDataContext = context;
            _httpcontextAccessor = httpContextAccessor;
        }

        // GET: api/Bases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Base>> GetBase(string id)
        {
            var Base = await _WCommodityDataContext.Bases.FindAsync(id);

            if (Base == null)
            {
                return NotFound();
            }

            return Base;
        }

         // GET: api/Bases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Base>>> GetBaseToList(string UserId)
        {
            var Base = await _WCommodityDataContext.Bases.Where(
                u => u.UserId.Equals(UserId)).ToListAsync();

            if (Base.Count.Equals(0))
            {
                return NotFound();
            }

            return Base;
        }

         // GET: api/Bases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Base>>> GetBase()
        {
            var UserId = _httpcontextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value; 
            var Base = await _WCommodityDataContext.Bases.Where(
                u => u.UserId.Equals(UserId)).ToListAsync();
            

            if (Base.Count.Equals(0))
            {
                return NotFound();
            }

            return Base;
        }

        // PUT: api/Bases/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBase(int id, Base Base)
        {
            if (id != Base.Id)
            {
                return BadRequest();
            }

            _WCommodityDataContext.Entry(Base).State = EntityState.Modified;

            try
            {
                await _WCommodityDataContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BaseExists(id))
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

        private bool BaseExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Bases
        [HttpPost]
        public async Task<ActionResult<Base>> PostBase(Base Base)
        {
            _WCommodityDataContext.Bases.Add(Base);
            await _WCommodityDataContext.SaveChangesAsync();

            //return CreatedAtAction("GetBase", new { id = Base.Id }, Base);
            return CreatedAtAction(nameof(GetBase), new { id = Base.Id }, Base);
        }

        // DELETE: api/Bases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBase(int id)
        {
            var Base = await _WCommodityDataContext.Bases.FindAsync(id);
            if (Base == null)
            {
                return NotFound();
            }

            _WCommodityDataContext.Bases.Remove(Base);
            await _WCommodityDataContext.SaveChangesAsync();

            return NoContent();
        }
    }
}