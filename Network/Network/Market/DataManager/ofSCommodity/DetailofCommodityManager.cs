using Market.IDataManager;
using Market.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.DataManager.ofSCommodity
{
    public class DetailofCommodityManager : IDetailofCommodityManager
    {
        private readonly SCommodityDataContext _scommodityDataContext;
  
        public DetailofCommodityManager(SCommodityDataContext scommodityDataContext)
        {
            _scommodityDataContext = scommodityDataContext;
        }

        public async Task<DetailofSCommodity> AddAsync(DetailofSCommodity DetailofCommodity)
        {
            _scommodityDataContext.DetailsofCommodity.Add(DetailofCommodity);     
            _scommodityDataContext.SaveChanges();

            return await _scommodityDataContext.DetailsofCommodity.OrderByDescending(e=>e.Id).FirstOrDefaultAsync();       
        }
        
        public DetailofSCommodity Add(DetailofSCommodity DetailofCommodity)
        {
            _scommodityDataContext.DetailsofCommodity.Add(DetailofCommodity);
            _scommodityDataContext.SaveChanges();

            return _scommodityDataContext.DetailsofCommodity.OrderByDescending(e=>e.Id).FirstOrDefault(); 
        }

        public async Task DeleteByIdAsync(int Id)
        {
            DetailofSCommodity DetailofCommodity = GetById(Id);
            _scommodityDataContext.DetailsofCommodity.Remove(DetailofCommodity);
            await _scommodityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int Id)
        {
            DetailofSCommodity DetailofCommodity = GetById(Id);
            _scommodityDataContext.DetailsofCommodity.Remove(DetailofCommodity);
            _scommodityDataContext.SaveChanges();
        }

        public async Task<DetailofSCommodity> GetByCommodityAsync(SCommodity commodity)
        {
            return await _scommodityDataContext.DetailsofCommodity.FirstOrDefaultAsync(
                u => u.SCommodity.Equals(commodity));
        }

        public DetailofSCommodity GetByCommodity(SCommodity commodity)
        {
            return _scommodityDataContext.DetailsofCommodity.FirstOrDefault(
                u => u.SCommodity.Equals(commodity));
        }

        public async Task<DetailofSCommodity> GetByIdAsync(int Id)
        {
            return await _scommodityDataContext.DetailsofCommodity.FindAsync(Id);
        }

        public DetailofSCommodity GetById(int Id)
        {
            return _scommodityDataContext.DetailsofCommodity.Find(Id);
        }

        public async Task<DetailofSCommodity> UpdateAsync(DetailofSCommodity DetailofCommodity)
        {
            DetailofSCommodity UpdateDetail = await GetByIdAsync(DetailofCommodity.Id);
            
            UpdateDetail.Authenticate = DetailofCommodity.Authenticate;
            UpdateDetail.Brand = DetailofCommodity.Brand;
            UpdateDetail.SCommodity = DetailofCommodity.SCommodity;
            UpdateDetail.Docs = DetailofCommodity.Docs;
            UpdateDetail.DurationTime = DetailofCommodity.DurationTime;
            UpdateDetail.Import = DetailofCommodity.Import;
            UpdateDetail.IsVAT = DetailofCommodity.IsVAT;
            UpdateDetail.MaximumPossibleQuantity = DetailofCommodity.MaximumPossibleQuantity;
            UpdateDetail.Menufactured = DetailofCommodity.Menufactured;
            UpdateDetail.PossibleUnder20 = DetailofCommodity.PossibleUnder20;
            UpdateDetail.WarehouseNo = DetailofCommodity.WarehouseNo;

            _scommodityDataContext.DetailsofCommodity.Update(UpdateDetail);
            await _scommodityDataContext.SaveChangesAsync();

            return UpdateDetail;
        }

        public DetailofSCommodity Update(DetailofSCommodity DetailofCommodity)
        {
            DetailofSCommodity UpdateDetail = GetById(DetailofCommodity.Id);

            UpdateDetail.Authenticate = DetailofCommodity.Authenticate;
            UpdateDetail.Brand = DetailofCommodity.Brand;
            UpdateDetail.Id = DetailofCommodity.Id;
            UpdateDetail.CommodityNo = DetailofCommodity.CommodityNo;
            UpdateDetail.Docs = DetailofCommodity.Docs;
            UpdateDetail.DurationTime = DetailofCommodity.DurationTime;
            UpdateDetail.Import = DetailofCommodity.Import;
            UpdateDetail.IsVAT = DetailofCommodity.IsVAT;
            UpdateDetail.MaximumPossibleQuantity = DetailofCommodity.MaximumPossibleQuantity;
            UpdateDetail.Menufactured = DetailofCommodity.Menufactured;
            UpdateDetail.PossibleUnder20 = DetailofCommodity.PossibleUnder20;
            UpdateDetail.WarehouseNo = DetailofCommodity.WarehouseNo;

            _scommodityDataContext.DetailsofCommodity.Update(UpdateDetail);
            _scommodityDataContext.SaveChanges();

            return UpdateDetail;
        }

        public async Task<List<DetailofSCommodity>> GetToListAsync()
        {
            return await _scommodityDataContext.DetailsofCommodity.ToListAsync();
        }

        public List<DetailofSCommodity> GetToList()
        {
            return _scommodityDataContext.DetailsofCommodity.ToList();
        }
    }
}
