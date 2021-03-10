using Logistics.Service;
using Logistics.ViewModel;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using Microsoft.AspNetCore.Components;
using System;

namespace Logistics.Pages.ofSCommodity
{
    public partial class Detail
    {
        [Inject] ISCommodityManager CommodityManager { get; set; } 
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] IDetailofSCommodityManager CommodityDetailManager {get; set;}
        [Inject] ISCommodityFileManager FileManager {get; set;}
        [Inject] IImageofDetailManager ImageofDetailManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        
        [Parameter] public string CommodityNo { get; set; }
        public CommodityModel commodityModel { get; set; }
        public SCommodity commodity { get; set; }

        protected override void OnInitialized()
        {
            commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            commodity.Options = OptionManager.GetToListByCommodity(commodity);
            commodity.DetailofSCommodity = CommodityDetailManager.GetByCommodity(commodity);
           
            //await ImageofDetailManager.GetByEntity(commodity.CommodityDetail);
            //await ImageofOptionManager.GetByEntities(commodity.Options);
        }     
    }
}
