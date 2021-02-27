using Import.DataManager;
using Import.ImportDataContext;
using Import.Model;
using Logistics.Service;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofCommodity
{
    public partial class Get
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] ICommodityFileManager CommodityFileManager { get; set; }
        //[Inject] NavigationManager NavigationManager { get; set; }

        public List<Commodity> Commodities { get; set; }
        public int CommodityNo { get; set; }
        public Commodity Commodity { get; set; }
      
        protected override void OnInitialized()
        {
            Commodities = CommodityManager.GetToList();
        }
   
        public bool DeleteDialogIsOpen { get; set; }
        public void DeleteDialogSwitch(int CommodityNo)
        {
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
            this.CommodityNo = CommodityNo;
        }

        public void DeleteCommodity(int CommodityNo)
        {
            Commodity = CommodityManager.GetById(CommodityNo);

            if (Commodity != null)
            {
                CommodityManager.DeleteByEntity(Commodity);
                CommodityFileManager.DeleteExampleImage(Commodity);
            }

            DeleteDialogIsOpen = false;
            Commodities = CommodityManager.GetToList();
        }

    }
}
