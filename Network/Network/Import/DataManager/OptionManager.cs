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

            return await _commotityDataContext.Options.OrderByDesending(e => e.OptionNo).FirstOrDefaultAsync<Option>();
        }

        public Option Add(Option option)
        {
            _commotityDataContext.Options.Add(option);
            _commotityDataContext.SaveChanges();

            return _commotityDataContext.Options.OrderByDesending(e => e.OptionNo).FirstOrDefault();
        }

        public async Task DeleteByEntity(Option option)
        {
            _commotityDataContext.Remove(OptionNo);
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

        /// <summary>
        /// 이미지도 함께
        /// </summary>
        /// <param name="OptionNo"></param>
        /// <returns></returns>
        public Option GetById(int OptionNo)
        {
            Option option = _commotityDataContext.Options.Find(OptionNo);
            option.Images = _commotityDataContext.ImageofOptions.Where(
                u => u.Option.Equals(option)).ToList();

            return option;
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
