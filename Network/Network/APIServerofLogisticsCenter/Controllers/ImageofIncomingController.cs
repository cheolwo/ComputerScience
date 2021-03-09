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
    public class ImageofIncomingController : ControllerBase
    {
        private readonly WarehouseDataContext _context;

        public ImageofIncomingController(WarehouseDataContext context)
        {
            _context = context;
        }

        // GET: api/ImagesofIncoming/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageofIncoming>> GetImageofIncoming(int id)
        {
            var ImageofIncoming = await _context.ImagesofIncoming.FindAsync(id);

            if (ImageofIncoming == null)
            {
                return NotFound();
            }

            return ImageofIncoming;
        }

        // PUT: api/ImagesofIncoming/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageofIncoming(int id, ImageofIncoming ImageofIncoming)
        {
            if (id != ImageofIncoming.Id)
            {
                return BadRequest();
            }

            _context.Entry(ImageofIncoming).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageofIncomingExists(id))
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

        // POST: api/ImagesofIncoming
        [HttpPost]
        public async Task<ActionResult<ImageofIncoming>> PostImageofIncoming(ImageofIncoming ImageofIncoming)
        {
            _context.ImagesofIncoming.Add(ImageofIncoming);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetImageofIncoming", new { id = ImageofIncoming.Id }, ImageofIncoming);
            return CreatedAtAction(nameof(GetImageofIncoming), new { id = ImageofIncoming.Id }, ImageofIncoming);
        }

        // DELETE: api/ImagesofIncoming/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageofIncoming(int id)
        {
            var ImageofIncoming = await _context.ImagesofIncoming.FindAsync(id);
            if (ImageofIncoming == null)
            {
                return NotFound();
            }

            _context.ImagesofIncoming.Remove(ImageofIncoming);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}