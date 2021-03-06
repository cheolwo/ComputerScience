﻿using Import.ImportDataContext;
using Import.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public class CommodityDetailManager : ICommodityDetailManager
    {
        private readonly CommotityDataContext _commotityDataContext;
  
        public CommodityDetailManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<CommodityDetail> AddAsync(CommodityDetail commodityDetail)
        {
            _commotityDataContext.CommodityDetails.Add(commodityDetail);     
            _commotityDataContext.SaveChanges();

            return await _commotityDataContext.CommodityDetails.OrderByDescending(e=>e.CommodityDetailNo).FirstOrDefaultAsync();       
        }
        
        public CommodityDetail Add(CommodityDetail commodityDetail)
        {
            _commotityDataContext.CommodityDetails.Add(commodityDetail);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.CommodityDetails.OrderByDescending(e=>e.CommodityDetailNo).FirstOrDefault(); 
        }

        public async Task DeleteByIdAsync(int DetailNo)
        {
            CommodityDetail commodityDetail = GetById(DetailNo);
            _commotityDataContext.CommodityDetails.Remove(commodityDetail);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int DetailNo)
        {
            CommodityDetail commodityDetail = GetById(DetailNo);
            _commotityDataContext.CommodityDetails.Remove(commodityDetail);
            _commotityDataContext.SaveChanges();
        }

        public async Task<CommodityDetail> GetByCommodityAsync(Commodity commodity)
        {
            return await _commotityDataContext.CommodityDetails.FirstOrDefaultAsync(
                u => u.Commodity.Equals(commodity));
        }

        public CommodityDetail GetByCommodity(Commodity commodity)
        {
            return _commotityDataContext.CommodityDetails.FirstOrDefault(
                u => u.Commodity.Equals(commodity));
        }

        public async Task<CommodityDetail> GetByIdAsync(int DetailNo)
        {
            return await _commotityDataContext.CommodityDetails.FindAsync(DetailNo);
        }

        public CommodityDetail GetById(int DetailNo)
        {
            return _commotityDataContext.CommodityDetails.Find(DetailNo);
        }

        public async Task<CommodityDetail> UpdateAsync(CommodityDetail commodityDetail)
        {
            CommodityDetail UpdateDetail = await GetByIdAsync(commodityDetail.CommodityDetailNo);
            
            UpdateDetail.Authenticate = commodityDetail.Authenticate;
            UpdateDetail.Brand = commodityDetail.Brand;
            UpdateDetail.Commodity = commodityDetail.Commodity;
            UpdateDetail.Docs = commodityDetail.Docs;
            UpdateDetail.DurationTime = commodityDetail.DurationTime;
            UpdateDetail.Import = commodityDetail.Import;
            UpdateDetail.IsVAT = commodityDetail.IsVAT;
            UpdateDetail.MaximumPossibleQuantity = commodityDetail.MaximumPossibleQuantity;
            UpdateDetail.Menufactured = commodityDetail.Menufactured;
            UpdateDetail.PossibleUnder20 = commodityDetail.PossibleUnder20;
            UpdateDetail.WarehouseNo = commodityDetail.WarehouseNo;

            _commotityDataContext.CommodityDetails.Update(UpdateDetail);
            await _commotityDataContext.SaveChangesAsync();

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
            UpdateDetail.Import = commodityDetail.Import;
            UpdateDetail.IsVAT = commodityDetail.IsVAT;
            UpdateDetail.MaximumPossibleQuantity = commodityDetail.MaximumPossibleQuantity;
            UpdateDetail.Menufactured = commodityDetail.Menufactured;
            UpdateDetail.PossibleUnder20 = commodityDetail.PossibleUnder20;
            UpdateDetail.WarehouseNo = commodityDetail.WarehouseNo;

            _commotityDataContext.CommodityDetails.Update(UpdateDetail);
            _commotityDataContext.SaveChanges();

            return UpdateDetail;
        }

        public async Task<List<CommodityDetail>> GetToListAsync()
        {
            return await _commotityDataContext.CommodityDetails.ToListAsync();
        }

        public List<CommodityDetail> GetToList()
        {
            return _commotityDataContext.CommodityDetails.ToList();
        }
    }
}
