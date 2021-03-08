[Route("api/[controller]")]
[ApiController]
public class DividedCommodityController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public DividedCommodityController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/DividedCommodities/5
[HttpGet("{id}")]
public async Task<ActionResult<DividedCommodity>> GetDividedCommodity(int id)
{
    var DividedCommodity = await _context.DividedCommodities.FindAsync(id);

    if (DividedCommodity == null)
    {
        return NotFound();
    }

    return DividedCommodity;
}

// PUT: api/DividedCommodities/5
[HttpPut("{id}")]
public async Task<IActionResult> PutDividedCommodity(int id, DividedCommodity DividedCommodity)
{
    if (id != DividedCommodity.Id)
    {
        return BadRequest();
    }

    _context.Entry(DividedCommodity).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!DividedCommodityExists(id))
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

// POST: api/DividedCommodities
[HttpPost]
public async Task<ActionResult<DividedCommodity>> PostDividedCommodity(DividedCommodity DividedCommodity)
{
    _context.DividedCommodities.Add(DividedCommodity);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetDividedCommodity", new { id = DividedCommodity.Id }, DividedCommodity);
    return CreatedAtAction(nameof(GetDividedCommodity), new { id = DividedCommodity.Id }, DividedCommodity);
}

// DELETE: api/DividedCommodities/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteDividedCommodity(int id)
{
    var DividedCommodity = await _context.DividedCommodities.FindAsync(id);
    if (DividedCommodity == null)
    {
        return NotFound();
    }

    _context.DividedCommodities.Remove(DividedCommodity);
    await _context.SaveChangesAsync();

    return NoContent();
}
}