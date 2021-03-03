using Import.DataManager;
using Import.Model;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Logistics.Pages.ofOption
{
    public partial class Create
    {
        [Inject] IOptionManager OptionManager { get; set; }
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        [Parameter] public bool AddDialogIsOpen { get; set; }
        [Parameter] public string CommodityNo { get; set; }

        [Parameter] public Option Option { get; set; }
        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();

        public EditContext EditContext { get; set; }
        public ImageofOption ImageofOption = new ImageofOption();
        
        public string ErrorMessage { get; set; }
        
        protected override void OnInitialized()
        {
            EditContext = new EditContext(Option);
            Option.Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
        }

        public void FileUpload () { }
        [Parameter] public EventCallback DialogSwitch { get; set; }
        [Parameter] public EventCallback Add { get; set; }

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

            NavigationManager.NavigateTo(string.Format("/Get/Commodity/Option/{0}", CommodityNo));

        }
    }
}
