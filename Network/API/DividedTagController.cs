[Route("api/[controller]")]
[ApiController]
public class DividedTagController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public DividedTagController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/DividedTags/5
[HttpGet("{id}")]
public async Task<ActionResult<DividedTag>> GetDividedTag(int id)
{
    var DividedTag = await _context.DividedTags.FindAsync(id);

    if (DividedTag == null)
    {
        return NotFound();
    }

    return DividedTag;
}

// PUT: api/DividedTags/5
[HttpPut("{id}")]
public async Task<IActionResult> PutDividedTag(int id, DividedTag DividedTag)
{
    if (id != DividedTag.Id)
    {
        return BadRequest();
    }

    _context.Entry(DividedTag).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!DividedTagExists(id))
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

// POST: api/DividedTags
[HttpPost]
public async Task<ActionResult<DividedTag>> PostDividedTag(DividedTag DividedTag)
{
    _context.DividedTags.Add(DividedTag);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetDividedTag", new { id = DividedTag.Id }, DividedTag);
    return CreatedAtAction(nameof(GetDividedTag), new { id = DividedTag.Id }, DividedTag);
}

// DELETE: api/DividedTags/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteDividedTag(int id)
{
    var DividedTag = await _context.DividedTags.FindAsync(id);
    if (DividedTag == null)
    {
        return NotFound();
    }

    _context.DividedTags.Remove(DividedTag);
    await _context.SaveChangesAsync();

    return NoContent();
}
}