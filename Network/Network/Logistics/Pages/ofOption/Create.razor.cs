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
        [Inject] ICommodityFileManager CommodityFileManager { get; set; }
        [Inject] IWebHostEnvironment Environment { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        public bool AddDialogIsOpen { get; set; }
        public Option Option = new Option();      
        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();
        public EditContext EditContext { get; set; }
        public ImageofOption ImageofOption = new ImageofOption();
        
        public string ErrorMessage { get; set; }
        public string CurrentPath { get; set; }

        protected override void OnInitialized()
        {
            EditContext = new EditContext(Option);
            AddDialogIsOpen = true;
        }

        public void AddDialogSwitch()
        {
           AddDialogIsOpen = !AddDialogIsOpen;
           NavigationManager.NavigateTo(CurrentPath);
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

        public void RefreshByCommodityNo(string CommodityNo)
        {
            var path = string.Format("{0}/{1}", "/Get/Commodity/Option", CommodityNo);
            NavigationManager.NavigateTo(path);
        }

        public async void Add()
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
                            await CommodityFileManager.UploadOptionImage(File, path);
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
    }
}
