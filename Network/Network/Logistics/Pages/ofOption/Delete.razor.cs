using Import.DataManager;
using Import.Model;
using Logistics.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Delete
    {
        [Parameter] public bool DeleteDialogIsOpen { get; set; }
        [Parameter] public string CommodityNo { get; set; }
        [Parameter] public int OptionNo { get; set; }

        [Inject] IOptionManager OptionManager { get; set; }
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        [Parameter] public EventCallback DialogSwitch { get; set; }

        public Option Option { get; set; }
        public Commodity Commodity { get; set; }

        protected override void OnInitialized()
        {
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));            
        }

        public void DeleteById(int OptionNo)
        {
            OptionManager.DeleteById(OptionNo);
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
            NavigationManager.NavigateTo(string.Format("Get/Commodity/Option/{0}", CommodityNo));
            
        }
    }
}
