using Import.ImportDataContext;
using Import.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import.DataManager
{
    public class CommodityManager : ICommodityManager
    {
        private readonly CommotityDataContext _CommodityDataContext;

        public CommodityManager(CommotityDataContext CommotityDataContext)
        {
            _CommodityDataContext = CommotityDataContext;
        }

        public async Task<Commodity> AddAsync(Commodity commodity)
        {
            _CommodityDataContext.Commodities.Add(commodity);
            await _CommodityDataContext.SaveChanges();
            return _CommodityDataContext.Commodities.OrderByDesending(e=>e.CommodityNo).FirstOrDefaultAsync();
        }

        public Commodity Add(Commodty commodity)
        {
            _CommodityDataContext.Add(commodity);
            _CommodityDataContext.SaveChanges();         
            return _CommodityDataContext.Commodities.OrderByDesending(e=>e.CommodityNo).FirstOrDefault();   
        }

        public Task<Commodity> GetByIdAsync(int id)
        {
            Commodity commodity  = await _CommodityDataContext.Commodities.FindAsync(id);         
            return commodity;
        }

        public Commodity GetById(int id)
        {
            return _CommodityDataContext.Commodities.Find(id);
        }

        public async Task<List<Commodity>> GetToListAsync()
        {
            return await _CommodityDataContext.Commodities.ToListAsync();
        }
   
        public List<Commodity> GetToList()
        {
            return _CommodityDataContext.Commodities.ToList();
        }


        /// <summary>
        /// UpdatingofName,Category,Url
        /// </summary>
        /// <param name="commodity"></param>
        /// <param name="EntityNo"></param>
        /// 
        public async Task<Commodity> Update(Commodity commodity)
        {
            Commodity UpdateCommodity = GetById(commodity.CommodityNo);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;
            UpdateCommodity.ImageTitle = commodity.ImageTitle;
            UpdateCommodity.ImageRoute = commodity.ImageRoute;

            _CommodityDataContext.Commodities.Update(UpdateCommodity);
            await _CommodityDataContext.SaveChangesAsync();

            return UpdateCommodity;
        }

        public Commodity Update(Commodity commodity)
        {
            Commodity UpdateCommodity = GetById(commodity.CommodityNo);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;
            UpdateCommodity.ImageTitle = commodity.ImageTitle;
            UpdateCommodity.ImageRoute = commodity.ImageRoute;

            _CommodityDataContext.Commodities.Update(UpdateCommodity);
            _CommodityDataContext.SaveChanges();

            return UpdateCommodity;
        }
        
        public async Task DeleteByEntityAsync(Commodity commodity)
        {
            _CommodityDataContext.Commodities.Remove(commodity);
            await _CommodityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(Commodity commodity)
        {
            _CommodityDataContext.Commodities.Remove(commodity);
            _CommodityDataContext.SaveChanges();
        }

        public Task DeleteByIdAsync(int id)
        {
             Commodity commodity = await _CommodityDataContext.Commodities.FirstOrDefaultAsync(
                e => e.CommodityNo.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            await DeleteByEntityAsync(commodity);     
        }

        public void DeleteById(int id)
        {
            Commodity commodity = _CommodityDataContext.Commodities.FirstOrDefault(
                e => e.CommodityNo.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            DeleteByEntity(commodity);        
        }

        //public void UpdateWithOptions(int EntityNo, Commodity commodity, List<Option> options)
        //{
        //    foreach (var option in options)
        //    {
        //        if(option.c)   
        //    }
        //    commodity.Options = options;

        //    Commodity UpdateCommodity = GetById(EntityNo);
        //    UpdateCommodity.Options = commodity.Options;

        //    _CommodityDataContext.SaveChanges();
        //}

        //public void UpdatWithDetail(int EntityNo, Commodity commodity, CommodityDetail detail)
        //{
        //    commodity.CommodityDetail = detail;
        //    Commodity UpdateCommodity = GetById(EntityNo);
        //    UpdateCommodity.CommodityDetail = commodity.CommodityDetail;

        //    _CommodityDataContext.SaveChanges();

        //}
    }
}
