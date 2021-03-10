using Market.IDataManager.ofSCommodity;
using Market.Model.ofSCommodity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.DataManager.ofSCommodity
{
    public class SCommodityManager : ISCommodityManager
    {
        private readonly SCommodityDataContext _SCommodityDataContext;

        public SCommodityManager(SCommodityDataContext CommotityDataContext)
        {
            _SCommodityDataContext = CommotityDataContext;
        }

        public async Task<SCommodity> AddAsync(SCommodity commodity)
        {
            _SCommodityDataContext.SCommodities.Add(commodity);
            await _SCommodityDataContext.SaveChangesAsync();
            return await _SCommodityDataContext.SCommodities.OrderByDescending(e=>e.Id).FirstOrDefaultAsync();
        }

        public SCommodity Add(SCommodity commodity)
        {
            _SCommodityDataContext.Add(commodity);
            _SCommodityDataContext.SaveChanges();         
            return _SCommodityDataContext.SCommodities.OrderByDescending(e=>e.Id).FirstOrDefault();   
        }

        public async Task<SCommodity> GetByIdAsync(int id)
        {
            return await _SCommodityDataContext.SCommodities.FindAsync(id);
        }

        public SCommodity GetById(int id)
        {
            return _SCommodityDataContext.SCommodities.Find(id);
        }

        public async Task<List<SCommodity>> GetToListAsync()
        {
            return await _SCommodityDataContext.SCommodities.ToListAsync();
        }
   
        public List<SCommodity> GetToList()
        {
            return _SCommodityDataContext.SCommodities.ToList();
        }

        public async Task<SCommodity> UpdateAsync(SCommodity commodity)
        {
            SCommodity UpdateCommodity = await GetByIdAsync(commodity.Id);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;
            UpdateCommodity.ImageTitle = commodity.ImageTitle;
            UpdateCommodity.ImageRoute = commodity.ImageRoute;

            _SCommodityDataContext.SCommodities.Update(UpdateCommodity);
            await _SCommodityDataContext.SaveChangesAsync();

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

            _SCommodityDataContext.SCommodities.Update(UpdateCommodity);
            _SCommodityDataContext.SaveChanges();

            return UpdateCommodity;
        }
        
        public async Task DeleteByEntityAsync(SCommodity commodity)
        {
            _SCommodityDataContext.SCommodities.Remove(commodity);
            await _SCommodityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(SCommodity commodity)
        {
            _SCommodityDataContext.SCommodities.Remove(commodity);
            _SCommodityDataContext.SaveChanges();
        }

        public async Task DeleteByIdAsync(int id)
        {
            SCommodity commodity = await _SCommodityDataContext.SCommodities.FirstOrDefaultAsync(
                e => e.Id.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            await DeleteByEntityAsync(commodity);     
        }

        public void DeleteById(int id)
        {
            SCommodity commodity = _SCommodityDataContext.SCommodities.FirstOrDefault(
                e => e.Id.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            DeleteByEntity(commodity);        
        }
    }
}
