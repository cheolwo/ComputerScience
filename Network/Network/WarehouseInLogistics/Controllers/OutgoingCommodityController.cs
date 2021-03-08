[Route("api/[controller]")]
[ApiController]
public class OutgoingCommodityController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public OutgoingCommodityController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/OutgoingCommodities/5
[HttpGet("{id}")]
public async Task<ActionResult<OutgoingCommodity>> GetOutgoingCommodity(int id)
{
    var OutgoingCommodity = await _context.OutgoingCommodities.FindAsync(id);

    if (OutgoingCommodity == null)
    {
        return NotFound();
    }

    return OutgoingCommodity;
}

// PUT: api/OutgoingCommodities/5
[HttpPut("{id}")]
public async Task<IActionResult> PutOutgoingCommodity(int id, OutgoingCommodity OutgoingCommodity)
{
    if (id != OutgoingCommodity.Id)
    {
        return BadRequest();
    }

    _context.Entry(OutgoingCommodity).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!OutgoingCommodityExists(id))
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

// POST: api/OutgoingCommodities
[HttpPost]
public async Task<ActionResult<OutgoingCommodity>> PostOutgoingCommodity(OutgoingCommodity OutgoingCommodity)
{
    _context.OutgoingCommodities.Add(OutgoingCommodity);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetOutgoingCommodity", new { id = OutgoingCommodity.Id }, OutgoingCommodity);
    return CreatedAtAction(nameof(GetOutgoingCommodity), new { id = OutgoingCommodity.Id }, OutgoingCommodity);
}

// DELETE: api/OutgoingCommodities/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteOutgoingCommodity(int id)
{
    var OutgoingCommodity = await _context.OutgoingCommodities.FindAsync(id);
    if (OutgoingCommodity == null)
    {
        return NotFound();
    }

    _context.OutgoingCommodities.Remove(OutgoingCommodity);
    await _context.SaveChangesAsync();

    return NoContent();
}
}