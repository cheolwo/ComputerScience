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
        
        public bool CreateDialogIsOpen {get; set;}
        public bool UpdateDialogIsOpen {get; set;}
        public bool DeleteDialogIsOpen { get; set; }
        
        protected override void OnInitialized()
        {
            Commodities = CommodityManager.GetToList();
        }
   
        public void DeleteCommodity(int CommodityNo)
        {
            Commodity = CommodityManager.GetById(CommodityNo);

            if (Commodity != null)
            {
                CommodityManager.DeleteByEntity(Commodity);
                CommodityFileManager.DeleteCommodityImageByCommodity(Commodity);
            }

            DeleteDialogIsOpen = false;
            Commodities = CommodityManager.GetToList();
        }
        
        public void CreateDialogSwith()
        {
            CreateDialogIsOpen = !CreateDialogIsOpen;
        }
                
        public void UpdateDialogSwitch()
        {
            UpdateDialogIsOpen = !UpdateDialogIsOpen;
        }
               
        public void DeleteDialogSwitch()
        {
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }

    }
}
