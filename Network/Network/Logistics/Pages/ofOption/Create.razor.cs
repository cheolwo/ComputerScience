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
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        [Inject] ICommodityFileManager FileManager {get; set;}

        [Parameter] public bool AddDialogIsOpen { get; set; }
        [Parameter] public string CommodityNo { get; set; }
        public Option Option = new Option();

        public List<IMatFileUploadEntry> Files = new List<IMatFileUploadEntry>();
        public ImageofOption ImageofOption = new ImageofOption();
        
        public EditContext EditContext { get; set; }
        
        protected override void OnInitialized()
        {
            EditContext = new EditContext(Option);
            Option.Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));         
        }

        public void FileUpload (IMatFileUploadEntry[] Entryies)
        {
            if(Entryies != null)
            {
                foreach (var Entry in Entryies)
                {
                    Files.Add(Entry);
                }
            }
        }

        public async void Add()
        {
            bool Validate = EditContext.IsValidate();
            string Route;

            if(Validate)
            {
                try
                {
                    var AddOption = await OptionManager.AddAsync(Option);
                    if(Files != null)
                    {
                        ImageofOption.Option = AddOption;
                        foreach (var File in Files)
                        {
                            Route = await FileManager.UploadOptionImage(File);
                            ImageofOption.Name = File.Name;
                            ImageofOption.ImageRoute = Route;
                            await ImageofOptionManager.Add(ImageofOption);
                        }
                    }
                }
                catch (System.Exception)
                {     
                    throw;
                }
                finally
                {
                    Reset();
                    AddDialogIsOpen = false;
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
            Option.Key = null;
            Option.NormalPrice = null;
            Option.OptionNo = 0;
            Option.Quantity = 0;
            Option.SalePrice = null;
            Option.SellerCodeofCommodity = null;
            Option.Value = null;
        }
    }
}
