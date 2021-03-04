using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            return await _commotityDataContext.Options.OrderByDesending(e => e.OptionNo).FirstOrDefaultAsync();
        }

        public Option Add(Option option)
        {
            _commotityDataContext.Options.Add(option);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.Options.OrderByDesending(e => e.OptionNo).FirstOrDefault();
        }

        public async Task DeleteByEntity(Option option)
        {
            _CommodityDataContext.Options.Remove(option);
            await _CommodityDataContext.SaveChangesAsync();        
        }
        public void DeleteByEntity(Option option)
        {
            _CommodityDataContext.Options.Remove(option)
            _CommodityDataContext.SaveChanges();            
        }
        
        public async Task DeleteById(int optionNo)
        {
            Option option = await GetByIdAsync(optionNo);
            _commotityDataContext.Options.Remove(option);
            await _CommodityDataContext.SaveChangesAsync();            
        }

        public void DeleteById(int optionNo)
        {
            Option option = GetById(optionNo);
            _commotityDataContext.Options.Remove(option);
            _commotityDataContext.SaveChanges();
        }

        public async Task<List<Option>> GetToListByCommodityAsync(Commodity commodity)
        {
            return await _commotityDataContext.Options.ToListAsync();
        }

        public List<Option> GetToListByCommodity(Commodity commodity)
        {
            return _CommodityDataContext.Options.ToList();
        }

        public async Task<Option> GetByIdAsync(int optionNo)
        {
            return _CommodityDataContext.Options.FindAsync(optionNo);
        }

        public Option GetById(int optionNo)
        {
            return _CommodityDataContext.Options.Find(optionNo);
        }

        public async Task<Option> Update(Option option)
        {
            Option UpdateOption = await GetByIdAsync(option.OptionNo);
            UpdateOption.Commodity = option.Commodity;
            UpdateOption.CommotityBarcode = option.CommotityBarcode;
            UpdateOption.SellerCodeofCommodity = option.SellerCodeofCommodity;
            UpdateOption.Images = option.Images;
            UpdateOption.ModelNo = option.ModelNo;
            UpdateOption.Name = option.Name; // 색상
            UpdateOption.Value = option.Value; // 빨, 주, 노, 초
            UpdateOption.NormalPrice = option.NormalPrice;
            UpdateOption.Quantity = option.Quantity;
            UpdateOption.SalePrice = option.SalePrice;

            _commotityDataContext.Options.Update(UpdateOption);
            await _commotityDataContext.SaveChangesAsync();

            return UpdateOption;
        }
        
        public Option Update(Option option)
        {
            Option UpdateOption = GetById(option.OptionNo);
            UpdateOption.Commodity = option.Commodity;
            UpdateOption.CommotityBarcode = option.CommotityBarcode;
            UpdateOption.SellerCodeofCommodity = option.SellerCodeofCommodity;
            UpdateOption.Images = option.Images;
            UpdateOption.ModelNo = option.ModelNo;
            UpdateOption.Name = option.Name; // 색상
            UpdateOption.Value = option.Value; // 빨, 주, 노, 초
            UpdateOption.NormalPrice = option.NormalPrice;
            UpdateOption.Quantity = option.Quantity;
            UpdateOption.SalePrice = option.SalePrice;

            _commotityDataContext.Options.Update(UpdateOption);
            _commotityDataContext.SaveChanges();

            return UpdateOption;
        }
    }
}
