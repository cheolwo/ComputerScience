using Import.DataManager;
using Import.ImportDataContext;
using Import.Model;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Get
    {        
        [Inject] IOptionManager OptionManager { get; set; }   
        [Inject] ICommodityManager CommodityManager {get; set;}       
        [Parameter] public string CommodityNo { get; set; }
              
        public List<Option> Options = new List<Option>();
        public Commodity Commodity = new Commodity();
        public Option Option = new Option();
        
        public string OptionNo {get; set;} 
        public bool AddDialogIsOpen = false;
        public bool DeleteDialogIsOpen = false;
        
        protected override void OnInitialized()
        {
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Option.Commodity = Commodity;
            Options = OptionManager.GetByCommodityToList(Commodity);
        }

        public void AddDialogSwitch()
        {
            AddDialogIsOpen = !AddDialogIsOpen;
        }

        public void DeleteDialogSwitch()
        {
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }


    }
}
