using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public BaseController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/Bases/5
[HttpGet("{id}")]
public async Task<ActionResult<Base>> GetBase(int id)
{
    var Base = await _context.Bases.FindAsync(id);

    if (Base == null)
    {
        return NotFound();
    }

    return Base;
}

// PUT: api/Bases/5
[HttpPut("{id}")]
public async Task<IActionResult> PutBase(int id, Base Base)
{
    if (id != Base.Id)
    {
        return BadRequest();
    }

    _context.Entry(Base).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!BaseExists(id))
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

// POST: api/Bases
[HttpPost]
public async Task<ActionResult<Base>> PostBase(Base Base)
{
    _context.Bases.Add(Base);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetBase", new { id = Base.Id }, Base);
    return CreatedAtAction(nameof(GetBase), new { id = Base.Id }, Base);
}

// DELETE: api/Bases/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteBase(int id)
{
    var Base = await _context.Bases.FindAsync(id);
    if (Base == null)
    {
        return NotFound();
    }

    _context.Bases.Remove(Base);
    await _context.SaveChangesAsync();

    return NoContent();
}
}