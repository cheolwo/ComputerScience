using Import.DataManager;
using Import.ImportDataContext;
using Import.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Pages.ofCommodity
{
    public partial class Get
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        public List<Commodity> Commodities { get; set; }

        protected override void OnInitialized()
        {
            Commodities = CommodityManager.GetToList();
        }

    }
}
