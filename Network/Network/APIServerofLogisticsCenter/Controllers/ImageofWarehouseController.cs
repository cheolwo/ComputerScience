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
    public class ImageofBaseController : ControllerBase
    {
        private readonly WCommodityDataContext _context;

        public ImageofBaseController(WCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/ImageofBases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageofBase>> GetImageofBase(int id)
        {
            var ImageofBase = await _context.ImagesofBase.FindAsync(id);

            if (ImageofBase == null)
            {
                return NotFound();
            }

            return ImageofBase;
        }

        // PUT: api/ImageofBases/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageofBase(int id, ImageofBase ImageofBase)
        {
            if (id != ImageofBase.Id)
            {
                return BadRequest();
            }

            _context.Entry(ImageofBase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageofBaseExists(id))
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

        private bool ImageofBaseExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/ImageofBases
        [HttpPost]
        public async Task<ActionResult<ImageofBase>> PostImageofBase(ImageofBase ImageofBase)
        {
            _context.ImagesofBase.Add(ImageofBase);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetImageofBase", new { id = ImageofBase.Id }, ImageofBase);
            return CreatedAtAction(nameof(GetImageofBase), new { id = ImageofBase.Id }, ImageofBase);
        }

        // DELETE: api/ImageofBases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageofBase(int id)
        {
            var ImageofBase = await _context.ImagesofBase.FindAsync(id);
            if (ImageofBase == null)
            {
                return NotFound();
            }

            _context.ImagesofBase.Remove(ImageofBase);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}