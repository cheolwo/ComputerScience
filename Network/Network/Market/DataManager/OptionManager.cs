using Market.IDataManager;
using Market.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Market.DataManager
{
    public class OptionManager : IOptionManager
    {
        private readonly SCommodityDataContext _commotityDataContext;

        public OptionManager(SCommodityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<Option> AddAsync(Option option)
        {
            _commotityDataContext.Options.Add(option);
            _commotityDataContext.SaveChanges();

            return await _commotityDataContext.Options.OrderByDescending(e => e.Id).FirstOrDefaultAsync();
        }

        public Option Add(Option option)
        {
            _commotityDataContext.Options.Add(option);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.Options.OrderByDescending(e => e.Id).FirstOrDefault();
        }

        public async Task<List<Option>> GetToListByCommodityAsync(SCommodity commodity)
        {
            return await _commotityDataContext.Options.ToListAsync();
        }

        public List<Option> GetToListByCommodity(SCommodity commodity)
        {
            return _commotityDataContext.Options.Where(u => u.SCommodity.Equals(commodity)).ToList();
        }

        public async Task<Option> GetByIdAsync(int Id)
        {
            return await _commotityDataContext.Options.FindAsync(Id);
        }

        public Option GetById(int Id)
        {
            return _commotityDataContext.Options.Find(Id);
        }

        public async Task<Option> UpdateAsync(Option option)
        {
            Option UpdateOption = await GetByIdAsync(option.Id);
            UpdateOption.SCommodity = option.SCommodity;
           // UpdateOption.CommotityBarcode = option.CommotityBarcode;
            //UpdateOption.SellerCodeofCommodity = option.SellerCodeofCommodity;
            UpdateOption.Images = option.Images;
           // UpdateOption.ModelNo = option.ModelNo;
            UpdateOption.Key = option.Key; // 색상
            UpdateOption.Value = option.Value; // 빨, 주, 노, 초
           // UpdateOption.NormalPrice = option.NormalPrice;
           // UpdateOption.Quantity = option.Quantity;
           // UpdateOption.SalePrice = option.SalePrice;

            _commotityDataContext.Options.Update(UpdateOption);
            await _commotityDataContext.SaveChangesAsync();

            return UpdateOption;
        }

        public Option Update(Option option)
        {
            Option UpdateOption = GetById(option.Id);
            UpdateOption.SCommodity = option.SCommodity;
          //  UpdateOption.CommotityBarcode = option.CommotityBarcode;
          //  UpdateOption.SellerCodeofCommodity = option.SellerCodeofCommodity;
            UpdateOption.Images = option.Images;
           // UpdateOption.ModelNo = option.ModelNo;
            UpdateOption.Key = option.Key; // 색상
            UpdateOption.Value = option.Value; // 빨, 주, 노, 초
           // UpdateOption.NormalPrice = option.NormalPrice;
           // UpdateOption.Quantity = option.Quantity;
           // UpdateOption.SalePrice = option.SalePrice;

            _commotityDataContext.Options.Update(UpdateOption);
            _commotityDataContext.SaveChanges();

            return UpdateOption;
        }

        public async Task DeleteByIdAsync(int Id)
        {
            _commotityDataContext.Options.Remove(GetById(Id));
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int Id)
        {
            _commotityDataContext.Options.Remove(GetById(Id));
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByEntityAsync(Option option)
        {
            _commotityDataContext.Remove(option.Id);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(Option option)
        {
            _commotityDataContext.Remove(option.Id);
            _commotityDataContext.SaveChanges();
        }
    }
}
