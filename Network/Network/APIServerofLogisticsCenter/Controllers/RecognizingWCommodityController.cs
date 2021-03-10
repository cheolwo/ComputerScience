using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Warehouse;
using Warehouse.Model;

namespace APIServerofLogisticsCenter.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class RecognizingWCommodityController : ControllerBase
    //{
    //    private readonly WCommodityDataContext _WContext;
    //    private readonly TCommodityDataContext _TContext;

    //    public WCommodityController(WCommodityDataContext WContext, TCommodityDataContext TContext)
    //    {
    //        _WContext = WContext;
    //        _TContext = TContext;
    //    }

        //// GET: api/RecognizingWCommodity/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<RecognizingWCommodity>> GetRecognizingWCommodity(string CodeofBase)
        //{
        //    RecognizingWCommodity RecognizingWCommodity = new RecognizingWCommodity();
        //    RecognizingWCommodity.CrossDockingCommodityofBuyer = await _TContext.TCommodities.Where(
        //        u => u.CodeofCrossDockingBaseForBuyer.Equals(CodeofBase);
        //    ).ToListAsync();

        //    RecognizingWCommodity.CodeofCrossDockingBaseForSeller = await _TContext.TCommodities.Where(
        //        u => u.CodeofCrossDockingBaseForSeller.Equals(CodeofBase);
        //    ).ToListAsync();

        //    RecognizingWCommodity.LogisticsAgencyCommodityofBuyer = await _TContext.TCommodities.Where(
        //        u => u.CodeofSellerBase.Equals(CodeofBase)
        //    ).ToListAsync();

        //    if (RecognizingWCommodity.CrossDockingCommodityofBuyer.Count.Equals(0) && 
        //        RecognizingWCommodity.CrossDockingCommodityofSeller.Count.Equals(0) &&
        //        RecognizingWCommodity.LogisticsAgencyCommodityofBuyer.Count.Equals(0))
        //    {
        //        return NotFound();
        //    }

        //    return RecognizingWCommodity;
        //}

    //     // PUT: api/WCommodities/5
    //     [HttpPut("{id}")]
    //     public async Task<IActionResult> PutRecognizingWCommodity(int id, RecognizingWCommodity RecognizingWCommodity)
    //     {
    //         if (id != RecognizingWCommodity.Id)
    //         {
    //             return BadRequest();
    //         }

    //         _WContext.Entry(RecognizingWCommodity).State = EntityState.Modified;

    //         try
    //         {
    //             await _WContext.SaveChangesAsync();
    //         }
    //         catch (DbUpdateConcurrencyException)
    //         {
    //             if (!RecognizingWCommodityExists(id))
    //             {
    //                 return NotFound();
    //             }
    //             else
    //             {
    //                 throw;
    //             }
    //         }

    //         return NoContent();
    //     }

    //     private bool RecognizingWCommodityExists(int id)
    //     {
    //         throw new NotImplementedException();
    //     }

    //     // DELETE: api/WCommodities/5
    //     [HttpDelete("{id}")]
    //     public async Task<IActionResult> DeleteRecognizingWCommodity(int id)
    //     {
    //         var RecognizingWCommodity = await _WContext.WCommodities.FindAsync(id);
    //         if (RecognizingWCommodity == null)
    //         {
    //             return NotFound();
    //         }

    //         _WContext.WCommodities.Remove(RecognizingWCommodity);
    //         await _WContext.SaveChangesAsync();

    //         return NoContent();
    //     }
    // }
}