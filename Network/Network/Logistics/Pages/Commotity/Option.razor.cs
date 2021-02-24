using Import.ImportDataContext;
using Import.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.Commotity
{
    public partial class Option
    {
        [Inject] CommotityDataContext CommotityDataContext { get; set; }
        public List<Option> Options { get; set; }
        public Commodity CommodityByParameter { get; set; }

        protected override void OnInitialized()
        {
            CommodityByParameter = CommotityDataContext.Commodities.FirstOrDefault(
                u => u.CommodityNo.Equals(Convert.ToInt32(CommodityNo)));

           
        }
        
        [Parameter]
        public string CommodityNo { get; set; }
        
    }
}
