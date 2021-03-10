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
    public class ImageofPackController : ControllerBase
    {
        private readonly WCommodityDataContext _context;

        public ImageofPackController(WCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/ImagesofPack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageofPack>> GetImageofPack(int id)
        {
            var ImageofPack = await _context.ImagesofPack.FindAsync(id);

            if (ImageofPack == null)
            {
                return NotFound();
            }

            return ImageofPack;
        }

        // PUT: api/ImagesofPack/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageofPack(int id, ImageofPack ImageofPack)
        {
            if (id != ImageofPack.Id)
            {
                return BadRequest();
            }

            _context.Entry(ImageofPack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageofPackExists(id))
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

        private bool ImageofPackExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/ImagesofPack
        [HttpPost]
        public async Task<ActionResult<ImageofPack>> PostImageofPack(ImageofPack ImageofPack)
        {
            _context.ImagesofPack.Add(ImageofPack);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetImageofPack", new { id = ImageofPack.Id }, ImageofPack);
            return CreatedAtAction(nameof(GetImageofPack), new { id = ImageofPack.Id }, ImageofPack);
        }

        // DELETE: api/ImagesofPack/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageofPack(int id)
        {
            var ImageofPack = await _context.ImagesofPack.FindAsync(id);
            if (ImageofPack == null)
            {
                return NotFound();
            }

            _context.ImagesofPack.Remove(ImageofPack);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}