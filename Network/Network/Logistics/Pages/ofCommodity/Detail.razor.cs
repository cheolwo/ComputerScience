using Import.DataManager;
using Import.Model;
using Logistics.ViewModel;
using Microsoft.AspNetCore.Components;
using System;
using System.Drawing;
using System.IO;

namespace Logistics.Pages.ofCommodity
{
    public partial class Detail
    {
        [Inject] ICommodityManager CommodityManager { get; set; } 
        [Parameter] public string CommodityNo { get; set; }
        public CommodityModel commodityModel { get; set; }
        public Commodity commodity { get; set; }

        protected override void OnInitialized()
        {
            commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
        }
              
    }
}
