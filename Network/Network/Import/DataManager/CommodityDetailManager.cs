using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Import.DataManager
{
    public class CommodityDetailManager : ICommodityDetailManager
    {
        private readonly CommotityDataContext _commotityDataContext;
        public CommodityDetail CommodityDetail {get; set;}

        public CommodityDetailManager(CommotityDataContext commotityDataContext)
        {
            _commotityDataContext = commotityDataContext;
            CommodityDetail.DefaultValue();
        }
        
        public void Add(CommodityDetail commodityDetail)
        {
            _commotityDataContext.CommodityDetails.Add(commodityDetail);
            _commotityDataContext.SaveChanges();
        }

        public void DeleteById(int DetailNo)
        {
            CommodityDetail commodityDetail = GetById(DetailNo);
            _commotityDataContext.CommodityDetails.Remove(commodityDetail);
            _commotityDataContext.SaveChanges();
        }

        public CommodityDetail GetByCommodity(Commodity commodity)
        {
            return _commotityDataContext.CommodityDetails.FirstOrDefault(
                u => u.Commodity.Equals(commodity));
        }

        public CommodityDetail GetById(int DetailNo)
        {
            return _commotityDataContext.CommodityDetails.Find(DetailNo);
        }

        public void Update(int DetailNo, CommodityDetail commodityDetail)
        {
            CommodityDetail UpdateDetail = GetById(DetailNo);
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
            UpdateDetail.WarehouseCode = commodityDetail.WarehouseCode;

            _commotityDataContext.CommodityDetails.Update(UpdateDetail);
            _commotityDataContext.SaveChanges();
        }
    }
}
