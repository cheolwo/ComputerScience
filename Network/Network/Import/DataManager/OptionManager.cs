using Import.ImportDataContext;
using Import.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public class OptionManager : IOptionManager
    {
        private readonly CommotityDataContext _commotityDataContext;

        public OptionManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public async Task<Option> AddAsync(Option option)
        {
            _commotityDataContext.Options.Add(option);
            _commotityDataContext.SaveChanges();

            return await _commotityDataContext.Options.OrderByDescending(e => e.OptionNo).FirstOrDefaultAsync();
        }

        public Option Add(Option option)
        {
            _commotityDataContext.Options.Add(option);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.Options.OrderByDescending(e => e.OptionNo).FirstOrDefault();
        }

        public async Task<List<Option>> GetToListByCommodityAsync(Commodity commodity)
        {
            return await _commotityDataContext.Options.ToListAsync();
        }

        public List<Option> GetToListByCommodity(Commodity commodity)
        {
            return _commotityDataContext.Options.Where(u => u.Commodity.Equals(commodity)).ToList();
        }

        public async Task<Option> GetByIdAsync(int optionNo)
        {
            return await _commotityDataContext.Options.FindAsync(optionNo);
        }

        public Option GetById(int optionNo)
        {
            return _commotityDataContext.Options.Find(optionNo);
        }

        public async Task<Option> UpdateAsync(Option option)
        {
            Option UpdateOption = await GetByIdAsync(option.OptionNo);
            UpdateOption.Commodity = option.Commodity;
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
            Option UpdateOption = GetById(option.OptionNo);
            UpdateOption.Commodity = option.Commodity;
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

        public async Task DeleteByIdAsync(int optionNo)
        {
            _commotityDataContext.Options.Remove(GetById(optionNo));
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteById(int optionNo)
        {
            _commotityDataContext.Options.Remove(GetById(optionNo));
            _commotityDataContext.SaveChanges();
        }

        public async Task DeleteByEntityAsync(Option option)
        {
            _commotityDataContext.Remove(option.OptionNo);
            await _commotityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(Option option)
        {
            _commotityDataContext.Remove(option.OptionNo);
            _commotityDataContext.SaveChanges();
        }
    }
}
