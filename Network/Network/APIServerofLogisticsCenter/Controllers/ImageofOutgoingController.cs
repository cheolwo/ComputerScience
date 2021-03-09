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
    public class ImageofOutgoingController : ControllerBase
    {
        private readonly WarehouseDataContext _context;

        public ImageofOutgoingController(WarehouseDataContext context)
        {
            _context = context;
        }

        // GET: api/ImagesofOutgoing/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageofOutgoing>> GetImageofOutgoing(int id)
        {
            var ImageofOutgoing = await _context.ImagesofOutgoing.FindAsync(id);

            if (ImageofOutgoing == null)
            {
                return NotFound();
            }

            return ImageofOutgoing;
        }

        // PUT: api/ImagesofOutgoing/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageofOutgoing(int id, ImageofOutgoing ImageofOutgoing)
        {
            if (id != ImageofOutgoing.Id)
            {
                return BadRequest();
            }

            _context.Entry(ImageofOutgoing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageofOutgoingExists(id))
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

        // POST: api/ImagesofOutgoing
        [HttpPost]
        public async Task<ActionResult<ImageofOutgoing>> PostImageofOutgoing(ImageofOutgoing ImageofOutgoing)
        {
            _context.ImagesofOutgoing.Add(ImageofOutgoing);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetImageofOutgoing", new { id = ImageofOutgoing.Id }, ImageofOutgoing);
            return CreatedAtAction(nameof(GetImageofOutgoing), new { id = ImageofOutgoing.Id }, ImageofOutgoing);
        }

        // DELETE: api/ImagesofOutgoing/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageofOutgoing(int id)
        {
            var ImageofOutgoing = await _context.ImagesofOutgoing.FindAsync(id);
            if (ImageofOutgoing == null)
            {
                return NotFound();
            }

            _context.ImagesofOutgoing.Remove(ImageofOutgoing);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}