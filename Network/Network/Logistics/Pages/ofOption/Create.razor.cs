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

        [Property] public bool AddDialogIsOpen { get; set; }
        [Property] public List<Option> Options {get; set;}
        [Property] public string CommodityNo {get; set;}
        
        public Option Option = new Option();
        public Commodity Commodity = new Commodity();
        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();
        public EditContext EditContext { get; set; }
        public ImageofOption ImageofOption = new ImageofOption();
        
        public string ErrorMessage { get; set; }
        
        protected override void OnInitialized()
        {
            Commodity = ICommodityManager.GetById(Convert.ToInt32(CommodityNo));
            Option.Commodity = Commodity;
            EditContext = new EditContext(Option);
        }

        public void AddDialogSwitch()
        {
           AddDialogIsOpen = !AddDialogIsOpen;
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

        public async void Add()
        {
            bool Validate = EditContext.Validate();
            if (Validate)
            {
                try
                {
                    Option = await OptionManager.Add(Option);

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
                    Options.Add(Option);
                    Reset(Option);
                    AddDialogSwitch();
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    Reset();
                    AddDialogSwitch();
                }
            }
        }
        public void Reset(Option Option)
        {
            Files.Clear();
            Option.CommotityBarcode = null;
            Option.ModelNo = null;
            Option.Name = null;
            Option.NormalPrice = null;
            Option.Quantity = 0;
            Option.SalePrice = null;
            Option.SellerCodeofCommodity = null;
            Option.Value = null;
        }
    }
}
