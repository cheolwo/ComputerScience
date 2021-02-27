using Import.DataManager;
using Import.Model;
using Logistics.Service;
using Logistics.ViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace Logistics.Pages.ofCommodity
{
    public partial class Detail
    {
        [Inject] ICommodityManager CommodityManager { get; set; } 
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] ICommodityDetailManager CommodityDetailManager {get; set;}
        [Inject] ICommodityFileManager FileManager {get; set;}
        [Inject] IImageofDetailManager ImageofDetailManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        
        [Parameter] public string CommodityNo { get; set; }
        public CommodityModel commodityModel { get; set; }
        public Commodity commodity { get; set; }

        protected override async Task OnInitializedAsync()
        {
            commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            commodity.Options = OptionManager.GetByCommodityToList(commodity);
            commodity.CommodityDetail = CommodityDetailManager.GetByCommodity(commodity);
           
            await ImageofDetailManager.GetByEntity(commodity.CommodityDetail);
            await ImageofOptionManager.GetByEntities(commodity.Options);
        }     
    }
}
