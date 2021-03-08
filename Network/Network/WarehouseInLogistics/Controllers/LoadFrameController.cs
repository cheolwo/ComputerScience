[Route("api/[controller]")]
[ApiController]
public class LoadFrameController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public LoadFrameController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/LoadFrames/5
[HttpGet("{id}")]
public async Task<ActionResult<LoadFrame>> GetLoadFrame(int id)
{
    var LoadFrame = await _context.LoadFrames.FindAsync(id);

    if (LoadFrame == null)
    {
        return NotFound();
    }

    return LoadFrame;
}

// PUT: api/LoadFrames/5
[HttpPut("{id}")]
public async Task<IActionResult> PutLoadFrame(int id, LoadFrame LoadFrame)
{
    if (id != LoadFrame.Id)
    {
        return BadRequest();
    }

    _context.Entry(LoadFrame).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!LoadFrameExists(id))
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

// POST: api/LoadFrames
[HttpPost]
public async Task<ActionResult<LoadFrame>> PostLoadFrame(LoadFrame LoadFrame)
{
    _context.LoadFrames.Add(LoadFrame);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetLoadFrame", new { id = LoadFrame.Id }, LoadFrame);
    return CreatedAtAction(nameof(GetLoadFrame), new { id = LoadFrame.Id }, LoadFrame);
}

// DELETE: api/LoadFrames/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteLoadFrame(int id)
{
    var LoadFrame = await _context.LoadFrames.FindAsync(id);
    if (LoadFrame == null)
    {
        return NotFound();
    }

    _context.LoadFrames.Remove(LoadFrame);
    await _context.SaveChangesAsync();

    return NoContent();
}
}