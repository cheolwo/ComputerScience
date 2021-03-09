using Market.IDataManager;
using Market.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.DataManager.ofSCommodity
{
    public class SCommodityManager : ICommodityManager
    {
        private readonly SCommodityDataContext _CommodityDataContext;

        public SCommodityManager(SCommodityDataContext CommotityDataContext)
        {
            _CommodityDataContext = CommotityDataContext;
        }

        public async Task<SCommodity> AddAsync(SCommodity commodity)
        {
            _CommodityDataContext.Commodities.Add(commodity);
            await _CommodityDataContext.SaveChangesAsync();
            return await _CommodityDataContext.Commodities.OrderByDescending(e=>e.Id).FirstOrDefaultAsync();
        }

        public SCommodity Add(SCommodity commodity)
        {
            _CommodityDataContext.Add(commodity);
            _CommodityDataContext.SaveChanges();         
            return _CommodityDataContext.Commodities.OrderByDescending(e=>e.Id).FirstOrDefault();   
        }

        public async Task<SCommodity> GetByIdAsync(int id)
        {
            return await _CommodityDataContext.Commodities.FindAsync(id);
        }

        public SCommodity GetById(int id)
        {
            return _CommodityDataContext.Commodities.Find(id);
        }

        public async Task<List<SCommodity>> GetToListAsync()
        {
            return await _CommodityDataContext.Commodities.ToListAsync();
        }
   
        public List<SCommodity> GetToList()
        {
            return _CommodityDataContext.Commodities.ToList();
        }

        public async Task<SCommodity> UpdateAsync(SCommodity commodity)
        {
            SCommodity UpdateCommodity = await GetByIdAsync(commodity.Id);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;
            UpdateCommodity.ImageTitle = commodity.ImageTitle;
            UpdateCommodity.ImageRoute = commodity.ImageRoute;

            _CommodityDataContext.Commodities.Update(UpdateCommodity);
            await _CommodityDataContext.SaveChangesAsync();

            return UpdateCommodity;
        }

        public SCommodity Update(SCommodity commodity)
        {
            SCommodity UpdateCommodity = GetById(commodity.Id);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;
            UpdateCommodity.ImageTitle = commodity.ImageTitle;
            UpdateCommodity.ImageRoute = commodity.ImageRoute;

            _CommodityDataContext.Commodities.Update(UpdateCommodity);
            _CommodityDataContext.SaveChanges();

            return UpdateCommodity;
        }
        
        public async Task DeleteByEntityAsync(SCommodity commodity)
        {
            _CommodityDataContext.Commodities.Remove(commodity);
            await _CommodityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(SCommodity commodity)
        {
            _CommodityDataContext.Commodities.Remove(commodity);
            _CommodityDataContext.SaveChanges();
        }

        public async Task DeleteByIdAsync(int id)
        {
            SCommodity commodity = await _CommodityDataContext.Commodities.FirstOrDefaultAsync(
                e => e.Id.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            await DeleteByEntityAsync(commodity);     
        }

        public void DeleteById(int id)
        {
            SCommodity commodity = _CommodityDataContext.Commodities.FirstOrDefault(
                e => e.Id.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            DeleteByEntity(commodity);        
        }
    }
}
