using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trade.ICommodityDataManager;
using Trade.Model;

namespace Trade.CommodityDataManager
{
    public class CommodityDetailManager : ICommodityDetailManager
    {
        private readonly CommodityDataContext commodityDatacontext;
  
        public CommodityDetailManager(CommodityDataContext commotityDataContext)
        {
            commodityDatacontext = commotityDataContext;
        }

        public async Task<CommodityDetail> AddAsync(CommodityDetail commodityDetail)
        {
            commodityDatacontext.CommodityDetails.Add(commodityDetail);     
            commodityDatacontext.SaveChanges();

            return await commodityDatacontext.CommodityDetails.OrderByDescending(e=>e.CommodityDetailNo).FirstOrDefaultAsync();       
        }
        
        public CommodityDetail Add(CommodityDetail commodityDetail)
        {
            commodityDatacontext.CommodityDetails.Add(commodityDetail);
            commodityDatacontext.SaveChanges();

            return commodityDatacontext.CommodityDetails.OrderByDescending(e=>e.CommodityDetailNo).FirstOrDefault(); 
        }

        public async Task DeleteByIdAsync(int DetailNo)
        {
            CommodityDetail commodityDetail = GetById(DetailNo);
            commodityDatacontext.CommodityDetails.Remove(commodityDetail);
            await commodityDatacontext.SaveChangesAsync();
        }

        public void DeleteById(int DetailNo)
        {
            CommodityDetail commodityDetail = GetById(DetailNo);
            commodityDatacontext.CommodityDetails.Remove(commodityDetail);
            commodityDatacontext.SaveChanges();
        }

        public async Task<CommodityDetail> GetByCommodityAsync(Commodity commodity)
        {
            return await commodityDatacontext.CommodityDetails.FirstOrDefaultAsync(
                u => u.Commodity.Equals(commodity));
        }

        public CommodityDetail GetByCommodity(Commodity commodity)
        {
            return commodityDatacontext.CommodityDetails.FirstOrDefault(
                u => u.Commodity.Equals(commodity));
        }

        public async Task<CommodityDetail> GetByIdAsync(int DetailNo)
        {
            return await commodityDatacontext.CommodityDetails.FindAsync(DetailNo);
        }

        public CommodityDetail GetById(int DetailNo)
        {
            return commodityDatacontext.CommodityDetails.Find(DetailNo);
        }

        public async Task<CommodityDetail> UpdateAsync(CommodityDetail commodityDetail)
        {
            CommodityDetail UpdateDetail = await GetByIdAsync(commodityDetail.CommodityDetailNo);
            
            UpdateDetail.Authenticate = commodityDetail.Authenticate;
            UpdateDetail.Brand = commodityDetail.Brand;
            UpdateDetail.Commodity = commodityDetail.Commodity;
            UpdateDetail.Docs = commodityDetail.Docs;
            UpdateDetail.DurationTime = commodityDetail.DurationTime;
            UpdateDetail.Clearance = commodityDetail.Clearance;
            UpdateDetail.IsVAT = commodityDetail.IsVAT;
            UpdateDetail.MaximumPossibleQuantity = commodityDetail.MaximumPossibleQuantity;
            UpdateDetail.Menufactured = commodityDetail.Menufactured;
            UpdateDetail.PossibleUnder20 = commodityDetail.PossibleUnder20;
            UpdateDetail.WarehouseNo = commodityDetail.WarehouseNo;

            commodityDatacontext.CommodityDetails.Update(UpdateDetail);
            await commodityDatacontext.SaveChangesAsync();

            return UpdateDetail;
        }

        public CommodityDetail Update(CommodityDetail commodityDetail)
        {
            CommodityDetail UpdateDetail = GetById(commodityDetail.CommodityDetailNo);

            UpdateDetail.Authenticate = commodityDetail.Authenticate;
            UpdateDetail.Brand = commodityDetail.Brand;
            UpdateDetail.Commodity = commodityDetail.Commodity;
            UpdateDetail.CommodityNo = commodityDetail.CommodityNo;
            UpdateDetail.Docs = commodityDetail.Docs;
            UpdateDetail.DurationTime = commodityDetail.DurationTime;
            UpdateDetail.Clearance = commodityDetail.Clearance;
            UpdateDetail.IsVAT = commodityDetail.IsVAT;
            UpdateDetail.MaximumPossibleQuantity = commodityDetail.MaximumPossibleQuantity;
            UpdateDetail.Menufactured = commodityDetail.Menufactured;
            UpdateDetail.PossibleUnder20 = commodityDetail.PossibleUnder20;
            UpdateDetail.WarehouseNo = commodityDetail.WarehouseNo;

            commodityDatacontext.CommodityDetails.Update(UpdateDetail);
            commodityDatacontext.SaveChanges();

            return UpdateDetail;
        }

        public async Task<List<CommodityDetail>> GetToListAsync()
        {
            return await commodityDatacontext.CommodityDetails.ToListAsync();
        }

        public List<CommodityDetail> GetToList()
        {
            return commodityDatacontext.CommodityDetails.ToList();
        }
    }
}
