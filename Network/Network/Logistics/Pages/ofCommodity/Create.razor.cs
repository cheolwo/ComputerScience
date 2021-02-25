using Import.DataManager;
using Import.ImportDataContext;
using Import.Model;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Drawing;
using Logistics.Service;

namespace Logistics.Pages.ofCommodity
{
    /// <summary>
    /// File :
    /// </summary>
    public partial class Create
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] IFileManager FileManager { get; set; }
        [Inject] IMatFileManager MatFileManager { get; set; }
             
        public Commodity Commodity = new Commodity();

        protected override void OnInitialized()
        {

        }

        public bool DialogIsOpen { get; set; }
        [Parameter]
        public string CommodityNo { get; set; }

   
        public void AddToDirectory(Commodity commodity)
        {
           
        }

        public void Add()
        {
            // CommodityManager.Add(Commodity);
            AddToDirectory(Commodity);
        }
    }
}
