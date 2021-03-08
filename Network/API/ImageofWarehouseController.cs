[Route("api/[controller]")]
[ApiController]
public class ImageofWarehouseController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public ImageofWarehouseController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/ImagesofWarehouse/5
[HttpGet("{id}")]
public async Task<ActionResult<ImageofWarehouse>> GetImageofWarehouse(int id)
{
    var ImageofWarehouse = await _context.ImagesofWarehouse.FindAsync(id);

    if (ImageofWarehouse == null)
    {
        return NotFound();
    }

    return ImageofWarehouse;
}

// PUT: api/ImagesofWarehouse/5
[HttpPut("{id}")]
public async Task<IActionResult> PutImageofWarehouse(int id, ImageofWarehouse ImageofWarehouse)
{
    if (id != ImageofWarehouse.Id)
    {
        return BadRequest();
    }

    _context.Entry(ImageofWarehouse).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!ImageofWarehouseExists(id))
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

// POST: api/ImagesofWarehouse
[HttpPost]
public async Task<ActionResult<ImageofWarehouse>> PostImageofWarehouse(ImageofWarehouse ImageofWarehouse)
{
    _context.ImagesofWarehouse.Add(ImageofWarehouse);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetImageofWarehouse", new { id = ImageofWarehouse.Id }, ImageofWarehouse);
    return CreatedAtAction(nameof(GetImageofWarehouse), new { id = ImageofWarehouse.Id }, ImageofWarehouse);
}

// DELETE: api/ImagesofWarehouse/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteImageofWarehouse(int id)
{
    var ImageofWarehouse = await _context.ImagesofWarehouse.FindAsync(id);
    if (ImageofWarehouse == null)
    {
        return NotFound();
    }

    _context.ImagesofWarehouse.Remove(ImageofWarehouse);
    await _context.SaveChangesAsync();

    return NoContent();
}
}