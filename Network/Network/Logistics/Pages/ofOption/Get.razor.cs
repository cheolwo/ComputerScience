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
        [Inject] CommotityDataContext CommotityDataContext { get; set; }
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] ICommodityFileManager CommodityFileManager { get; set; }
        [Inject] IOptionManager OptionManager { get; set; }
        [Inject] IImageofOptionManager ImageofOptionManager { get; set; }
        [Inject] IWebHostEnvironment Environment { get; set; }
        
        public string ErrorMessage { get; set; }

        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();
        
        public List<Option> Options { get; set; }
        public Commodity Commodity { get; set; }
        public Option Option = new Option();
        public ImageofOption ImageofOption = new ImageofOption();
        public EditContext EditContext { get; set; }

        protected override void OnInitialized()
        {
            Commodity = CommotityDataContext.Commodities.FirstOrDefault(
                u => u.CommodityNo.Equals(Convert.ToInt32(CommodityNo)));

            Option.Commodity = Commodity;
            Options = OptionManager.GetByCommodityToList(Commodity);
            EditContext = new EditContext(Option);
        }

        public void FileUpload(IMatFileUploadEntry[] entries)
        {
            if (entries.Length > 0)
            {
                foreach (var entry in entries)
                {
                    var File = Files.FirstOrDefault(e => e.Equals(entry));
                    if (File == null) { Files.Add(entry); }
                }
            }        
        }

        /// <summary>
        /// 여기해야되..
        /// </summary>
        public void Add()
        {
            string path;
            if (EditContext.Validate())
            {
                try
                {
                    Option = OptionManager.Add(Option);

                    if (Files.Count > 0)
                    {
                        foreach (var File in Files)
                        {
                            path = Path.Combine(Environment.ContentRootPath, "wwwroot\\Images\\Option", File.Name);
                            ImageofOption.Option = Option;
                            ImageofOption.ImageRoute = path;
                            ImageofOption.ImageTitle = File.Name;
                            CommodityFileManager.UploadOptionImage(File, path);
                        }
                    }
                    AddDialogSwitch();
                    Reset();
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    AddDialogSwitch();
                    Reset();
                }
            }
        }

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
