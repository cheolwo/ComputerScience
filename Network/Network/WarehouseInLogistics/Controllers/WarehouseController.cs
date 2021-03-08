using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class WarehouseController : ControllerBase
{
    private readonly WarehouseDataContext _context;

    public WarehouseController(WarehouseDataContext context)
    {
        _context = context;
    }

// GET: api/Warehouses/5
[HttpGet("{id}")]
public async Task<ActionResult<Warehouse>> GetWarehouse(int id)
{
    var Warehouse = await _context.Warehouses.FindAsync(id);

    if (Warehouse == null)
    {
        return NotFound();
    }

    return Warehouse;
}

// PUT: api/Warehouses/5
[HttpPut("{id}")]
public async Task<IActionResult> PutWarehouse(int id, Warehouse Warehouse)
{
    if (id != Warehouse.Id)
    {
        return BadRequest();
    }

    _context.Entry(Warehouse).State = EntityState.Modified;

    try
    {
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
        if (!WarehouseExists(id))
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

// POST: api/Warehouses
[HttpPost]
public async Task<ActionResult<Warehouse>> PostWarehouse(Warehouse Warehouse)
{
    _context.Warehouses.Add(Warehouse);
    await _context.SaveChangesAsync();

    //return CreatedAtAction("GetWarehouse", new { id = Warehouse.Id }, Warehouse);
    return CreatedAtAction(nameof(GetWarehouse), new { id = Warehouse.Id }, Warehouse);
}

// DELETE: api/Warehouses/5
[HttpDelete("{id}")]
public async Task<IActionResult> DeleteWarehouse(int id)
{
    var Warehouse = await _context.Warehouses.FindAsync(id);
    if (Warehouse == null)
    {
        return NotFound();
    }

    _context.Warehouses.Remove(Warehouse);
    await _context.SaveChangesAsync();

    return NoContent();
}
}