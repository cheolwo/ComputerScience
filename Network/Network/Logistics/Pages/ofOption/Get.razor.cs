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
    /// <summary>
    /// 
    /// </summary>
    public partial class Get
    {
        [Inject] CommotityDataContext CommotityDataContext { get; set; }    
        [Inject] IOptionManager OptionManager { get; set; }
        [Inject] IImageofOptionManager ImageofOptionManager { get; set; }      
        [Inject] NavigationManager NavigationManager { get; set; }

        [Inject] Create Create { get; set; }

        public string ErrorMessage { get; set; }
        public string path { get; set; }

        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();
        
        public List<Option> Options { get; set; }
        public Commodity Commodity = new Commodity();
        public Option Option = new Option();
        public ImageofOption ImageofOption = new ImageofOption();
        public EditContext EditContext { get; set; }

        protected override void OnInitialized()
        {
            Commodity = CommotityDataContext.Commodities.FirstOrDefault(
                u => u.CommodityNo.Equals(Convert.ToInt32(CommodityNo)));

            Option.Commodity = Commodity;
            Options = OptionManager.GetByCommodityToList(Commodity);
            path = string.Format("{0}/{1}", "/Get/Commodity/Option", CommodityNo);
        }

        /// <summary>
        /// 
        /// </summary>

        public void Reset()
        {
            Files.Clear();
            Option.Commodity = null;
            Option.CommotityBarcode = null;
            Option.Images = null;
            Option.ModelNo = null;
            Option.Name = null;
            Option.NormalPrice = null;
            Option.OptionNo = 0;
            Option.Quantity = 0;
            Option.SalePrice = null;
            Option.SellerCodeofCommodity = null;
            Option.Value = null;
        }

        public void Delete()
        {
            DeleteDialogSwitch();
        }

        public void Update()
        {
            UpdateDialogSwitch();
        }

        [Parameter]
        public string CommodityNo { get; set; }

        public bool AddDialogIsOpen = false;
        public bool DeleteDialogIsOpen = false;
        public bool UpdateDialogIsOpen = false;

        public void AddDialogSwitch()
        {
            AddDialogIsOpen = !AddDialogIsOpen;
        }

        public void DeleteDialogSwitch()
        {
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
        }

        public void UpdateDialogSwitch()
        {
            UpdateDialogIsOpen = !UpdateDialogIsOpen;
        }
    }
}
