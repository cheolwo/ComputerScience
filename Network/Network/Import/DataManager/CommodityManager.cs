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
        private readonly ICommodityDetailManager _CommodityDetailManager;
        private readonly IOptionManager _OptionManager;

        public CommodityManager(CommotityDataContext CommotityDataContext, 
            ICommodityDetailManager commodityDetailManager, IOptionManager optionManager)
        {
            _CommodityDataContext = CommotityDataContext;
            _CommodityDetailManager = commodityDetailManager;
            _OptionManager = optionManager;
        }

        public void Add(Commodity commodity)
        {
            _CommodityDataContext.Add(commodity);
            _CommodityDataContext.SaveChanges();
        }

        public async Task AddAsync(Commodity commodity)
        {
            _CommodityDataContext.Add(commodity);
            await _CommodityDataContext.SaveChangesAsync();
        }

        public void DeleteByEntity(Commodity commodity)
        {
            _CommodityDataContext.Commodities.Remove(commodity);
            _CommodityDataContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Commodity commodity = _CommodityDataContext.Commodities.FirstOrDefault(
                e => e.CommodityNo.Equals(id));

            if (commodity == null) { throw new ArgumentNullException(); }

            DeleteByEntity(commodity);        
        }

        /// <summary>
        /// [Key] public int CommodityNo { get; set; }
        //  public string Name { get; set; }
        //  public string Category { get; set; }
        //  public string Url { get; set; }
        //  public List<Option> Options { get; set; }
        //  [ForeignKey("CommotityDetail")] public CommodityDetail CommodityDetail { get; set; }
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public Commodity GetById(int id)
        {
            Commodity commodity  = _CommodityDataContext.Commodities.Find(id);
            commodity.Options = _OptionManager.GetByCommodityToList(commodity);
            commodity.CommodityDetail = _CommodityDetailManager.GetByCommodity(commodity);

            return _CommodityDataContext.Commodities.Find(id);
        }

        public Commodity GetByIdWithOption(int id)
        {
            Commodity commodity = GetById(id);
        

            return commodity;
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
        public void Update(int EntityNo, Commodity commodity)
        {
            Commodity UpdateCommodity = GetById(EntityNo);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;

            _CommodityDataContext.Commodities.Update(UpdateCommodity);
            _CommodityDataContext.SaveChanges();
        }

        public void Update(Commodity commodity)
        {
            Commodity UpdateCommodity = GetById(commodity.CommodityNo);
            UpdateCommodity.Category = commodity.Category;
            UpdateCommodity.Name = commodity.Name;
            UpdateCommodity.Url = commodity.Url;

            _CommodityDataContext.Commodities.Update(UpdateCommodity);
            _CommodityDataContext.SaveChanges();
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
