using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Import.DataManager
{
    //[Key] public int OptionNo { get; set; }
    //public string Name { get; set; }
    //public string Value { get; set; }
    //public Commodity Commodity { get; set; }

    //public string NormalPrice { get; set; }
    //public string SalePrice { get; set; }
    //public int Quantity { get; set; }
    //public string SellerCodeofCommodity { get; set; }
    //public string ModelNo { get; set; }
    //public string CommotityBarcode { get; set; }

    ///// <summary>
    ///// 대표이미지
    ///// </summary>
    // public List<Image> Images { get; set; }

    public class OptionManager : IOptionManager
    {
        private readonly CommotityDataContext _commotityDataContext;

        public OptionManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
        }

        public void Add(Option option)
        {
            _commotityDataContext.Add(option);
            _commotityDataContext.SaveChanges();
        }

        public void DeleteById(int OptionNo)
        {
            _commotityDataContext.Remove(OptionNo);
            _commotityDataContext.SaveChanges();
        }

        public List<Option> GetByCommodityToList(Commodity commodity)
        {
            List<Option> options =  _commotityDataContext.Options.Where(e => e.Commodity.Equals(commodity)).ToList();
            
            foreach(var option in options)
            {
               
            }

            return options;
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

        public void Update(int OptionNo, Option option)
        {
            Option UpdateOption = GetById(OptionNo);
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
        }
    }
}
