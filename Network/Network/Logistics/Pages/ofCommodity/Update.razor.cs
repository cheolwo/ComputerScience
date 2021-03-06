using Import.DataManager;
using Import.Model;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Pages.ofCommodity
{
    public partial class Update
    {
        
        [Inject] public ICommodityManager CommodityManager { get; set; }
        [Inject] public ICommodityFileManager FileManager { get; set; }
        [Inject] public IWebHostEnvironment Environment { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        
        [Parameter] public int CommodityNo { get; set; }
        [Parameter] public bool UpdateDialogIsOpen {get; set;}
        [Parameter] public List<Commodity> Commodities {get; set;}
        [Parameter] public EventCallback DialogSwitch {get; set;}

        public IMatFileUploadEntry MatFile { get; set; }

        public Commodity Commodity = new Commodity();
        public string ImgName { get; set; }
        public string Img { get; set; }
 
        protected override void OnInitialized()
        {
            Commodity = CommodityManager.GetById(CommodityNo);
            ReadFile(Commodity);
        }

        public async void UpdateCommodity()
        {
            string path;
            try
            {
                if(MatFile != null)
                {
                    FileManager.DeleteCommodityImageByCommodity(Commodity);
                    path = await FileManager.UploadCommodityImage(MatFile);
                    Commodity.ImageRoute = path;
                    Commodity.ImageTitle = MatFile.Name;
                    await FileManager.UploadCommodityImage(MatFile);
                }    
               Commodity = CommodityManager.Update(Commodity);
            }
            catch
            {
                // Awesome...
            }
            finally
            {
                UpdateDialogIsOpen = false;
                Commodity.Category = null;
                Commodity.ImageRoute = null;
                Commodity.ImageTitle = null;
                Commodity.Name = null;
                Commodity.Url = null;
                NavigationManager.NavigateTo("/Get/Commodity", true);
            }         
        }

        public void UploadToBuffer(IMatFileUploadEntry[] MatFiles)
        {
            var File = MatFiles.FirstOrDefault();

            if (File != null)
            {
                MatFile = File;
            }
        }

        public void ReadFile(Commodity commodity)
        {
            ImgName = commodity.ImageTitle;
            Img = "/images/Commodity/" + ImgName;
        }
    }
}
