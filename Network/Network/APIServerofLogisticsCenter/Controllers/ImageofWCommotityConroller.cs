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
    public class ImageofWCommodityController : ControllerBase
    {
        private readonly WarehouseDataContext _context;

        public ImageofWCommodityController(WarehouseDataContext context)
        {
            _context = context;
        }

        // GET: api/ImagesofWCommodity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageofWCommodity>> GetImageofWCommodity(int id)
        {
            var ImageofWCommodity = await _context.ImagesofWCommodity.FindAsync(id);

            if (ImageofWCommodity == null)
            {
                return NotFound();
            }

            return ImageofWCommodity;
        }

        // PUT: api/ImagesofWCommodity/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageofWCommodity(int id, ImageofWCommodity ImageofWCommodity)
        {
            if (id != ImageofWCommodity.Id)
            {
                return BadRequest();
            }

            _context.Entry(ImageofWCommodity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageofWCommodityExists(id))
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

        // POST: api/ImagesofWCommodity
        [HttpPost]
        public async Task<ActionResult<ImageofWCommodity>> PostImageofWCommodity(ImageofWCommodity ImageofWCommodity)
        {
            _context.ImagesofWCommodity.Add(ImageofWCommodity);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetImageofWCommodity", new { id = ImageofWCommodity.Id }, ImageofWCommodity);
            return CreatedAtAction(nameof(GetImageofWCommodity), new { id = ImageofWCommodity.Id }, ImageofWCommodity);
        }

        // DELETE: api/ImagesofWCommodity/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageofWCommodity(int id)
        {
            var ImageofWCommodity = await _context.ImagesofWCommodity.FindAsync(id);
            if (ImageofWCommodity == null)
            {
                return NotFound();
            }

            _context.ImagesofWCommodity.Remove(ImageofWCommodity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}