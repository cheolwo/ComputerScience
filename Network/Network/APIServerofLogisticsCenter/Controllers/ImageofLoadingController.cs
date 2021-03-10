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
    public class ImageofLoadingController : ControllerBase
    {
        private readonly WCommodityDataContext _context;

        public ImageofLoadingController(WCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/ImagesofLoading/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImageofLoading>> GetImageofLoading(int id)
        {
            var ImageofLoading = await _context.ImagesofLoading.FindAsync(id);

            if (ImageofLoading == null)
            {
                return NotFound();
            }

            return ImageofLoading;
        }

        // PUT: api/ImagesofLoading/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImageofLoading(int id, ImageofLoading ImageofLoading)
        {
            if (id != ImageofLoading.Id)
            {
                return BadRequest();
            }

            _context.Entry(ImageofLoading).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageofLoadingExists(id))
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

        private bool ImageofLoadingExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/ImagesofLoading
        [HttpPost]
        public async Task<ActionResult<ImageofLoading>> PostImageofLoading(ImageofLoading ImageofLoading)
        {
            _context.ImagesofLoading.Add(ImageofLoading);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetImageofLoading", new { id = ImageofLoading.Id }, ImageofLoading);
            return CreatedAtAction(nameof(GetImageofLoading), new { id = ImageofLoading.Id }, ImageofLoading);
        }

        // DELETE: api/ImagesofLoading/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImageofLoading(int id)
        {
            var ImageofLoading = await _context.ImagesofLoading.FindAsync(id);
            if (ImageofLoading == null)
            {
                return NotFound();
            }

            _context.ImagesofLoading.Remove(ImageofLoading);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}