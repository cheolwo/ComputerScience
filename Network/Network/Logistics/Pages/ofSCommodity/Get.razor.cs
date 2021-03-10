using Logistics.Service;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Logistics.Pages.ofSCommodity
{
    public partial class Get
    {
        [Inject] ISCommodityManager SCommodityManager { get; set; }
        [Inject] ISCommodityFileManager CommodityFileManager { get; set; }
        //[Inject] NavigationManager NavigationManager { get; set; }

        public List<SCommodity> Commodities { get; set; }
        public int SCommodityNo { get; set; }
        public SCommodity SCommodity { get; set; }
        
        public bool CreateDialogIsOpen {get; set;}
        public bool UpdateDialogIsOpen {get; set;}
        public bool DeleteDialogIsOpen { get; set; }
        
        protected override void OnInitialized()
        {
            Commodities = SCommodityManager.GetToList();
        }
   
        public void DeleteSCommodity(int SCommodityNo)
        {
            SCommodity = SCommodityManager.GetById(SCommodityNo);

            if (SCommodity != null)
            {
                SCommodityManager.DeleteByEntity(SCommodity);
                CommodityFileManager.DeleteCommodityImageByCommodity(SCommodity);
            }

            DeleteDialogIsOpen = false;
            Commodities = SCommodityManager.GetToList();
        }
        
        public void CreateDialogSwitch()
        {
            CreateDialogIsOpen = !CreateDialogIsOpen;
        }

        public void UpdateDialogSwitch(int SCommodityNo)
        {
            this.SCommodityNo = SCommodityNo;
            UpdateDialogIsOpen = !UpdateDialogIsOpen;
        }

        public void UpdateDialogSwitch()
        {
            UpdateDialogIsOpen = !UpdateDialogIsOpen;
        }
               
        public void DeleteDialogSwitch(int SCommodityNo)
        {
            this.SCommodityNo = SCommodityNo;
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }
        public void DeleteDialogSwitch()
        {          
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }

    }
}
