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

        public string ErrorMessage { get; set; }

        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();
        public List<Option> Options = new List<Option>();
        public Commodity Commodity = new Commodity();
        public Option Option = new Option();
        public ImageofOption ImageofOption = new ImageofOption();

        [Parameter]
        public string CommodityNo { get; set; }

        public bool AddDialogIsOpen = false;
        public bool DeleteDialogIsOpen = false;
        public bool UpdateDialogIsOpen = false;

        public int DeleteOptionNo { get; set; }

        protected override void OnInitialized()
        {
            Commodity = CommotityDataContext.Commodities.FirstOrDefault(
                u => u.CommodityNo.Equals(Convert.ToInt32(CommodityNo)));

            Option.Commodity = Commodity;
            Options = OptionManager.GetByCommodityToList(Commodity);           
        }

        /// <summary>
        /// 
        /// </summary>

        public void Reset()
        {
            Files.Clear();
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

        public void Add()
        {
            OptionManager.Add(Option);
            Options = OptionManager.GetByCommodityToList(Commodity);
            AddDialogSwitch();
        }

        public void Delete()
        {
            DeleteDialogSwitch();
        }

        public void Update()
        {
            UpdateDialogSwitch();
        }

        public void AddDialogSwitch()
        {
            AddDialogIsOpen = !AddDialogIsOpen;
        }

        public void DeleteDialogSwitch(int OptionNo)
        {
            DeleteOptionNo = OptionNo;
            DeleteDialogIsOpen = !DeleteDialogIsOpen;
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
