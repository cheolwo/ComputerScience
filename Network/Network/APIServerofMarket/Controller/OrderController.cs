using Market;
using Market.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace APIServerofMarket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly MCommodityDataContext _context;

        public OrderController(MCommodityDataContext context)
        {
            _context = context;
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var Order = await _context.Orders.FindAsync(id);

            if (Order == null)
            {
                return NotFound();
            }

            return Order;
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order Order)
        {
            if (id != Order.Id)
            {
                return BadRequest();
            }

            _context.Entry(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        private bool OrderExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order Order)
        {
            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetOrder", new { id = Order.Id }, Order);
            return CreatedAtAction(nameof(GetOrder), new { id = Order.Id }, Order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var Order = await _context.Orders.FindAsync(id);
            if (Order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(Order);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}