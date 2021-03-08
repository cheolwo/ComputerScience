[Route("api/[controller]")]
[ApiController]
public class ImagesofDeliveringController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public ImagesofDeliveringController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/ImagesofDelivering/5
[HttpGet("{id}")]
public async Task<ActionResult<ImageofDelivering>> GetImageofDelivering(int id)
{
    var ImageofDelivering = await _context.ImagesofDelivering.FindAsync(id);

    if (ImageofDelivering == null)
    {
        return NotFound();
    }

    return ImageofDelivering;
}

// PUT: api/ImagesofDelivering/5
[HttpPut("{id}")]
public async Task<IActionResult> PutImageofDelivering(int id, ImageofDelivering ImageofDelivering)
{
    if (id != ImageofDelivering.Id)
    {
        return BadRequest();
    }

    _context.Entry(ImageofDelivering).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!ImageofDeliveringExists(id))
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

// POST: api/ImagesofDelivering
[HttpPost]
public async Task<ActionResult<ImageofDelivering>> PostImageofDelivering(ImageofDelivering ImageofDelivering)
{
    _context.ImagesofDelivering.Add(ImageofDelivering);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetImageofDelivering", new { id = ImageofDelivering.Id }, ImageofDelivering);
    return CreatedAtAction(nameof(GetImageofDelivering), new { id = ImageofDelivering.Id }, ImageofDelivering);
}

// DELETE: api/ImagesofDelivering/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteImageofDelivering(int id)
{
    var ImageofDelivering = await _context.ImagesofDelivering.FindAsync(id);
    if (ImageofDelivering == null)
    {
        return NotFound();
    }

    _context.ImagesofDelivering.Remove(ImageofDelivering);
    await _context.SaveChangesAsync();

    return NoContent();
}
}