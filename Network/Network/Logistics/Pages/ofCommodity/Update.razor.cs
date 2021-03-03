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
        
        [Parameter] public string CommodityNo { get; set; }
        [Parameter] public bool UpdateDialogIsOpen {get; set;}
        [Parameter] public List<Commodity> Commodities {get; set;}
        [Parameter] public EventCallBack DialogSwitch {get; set;}

        public IMatFileUploadEntry MatFile { get; set; }

        public Commodity Commodity = new Commodity();
        public string ImgName { get; set; }
        public string Img { get; set; }

        protected override async void OnInitializedAsync()
        {
            Commodity = await CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            ReadFile(Commodity);
        }

        public async void UpdateCommodity()
        {
            try
            {
                if(MatFile != null)
                {
                    string path = Path.Combine(Environment.ContentRootPath, "wwwroot\\Images", MatFile.Name);
                    File.Delete(Commodity.ImageRoute);
                    Commodity.ImageRoute = path;
                    Commodity.ImageTitle = MatFile.Name;
                    FileManager.UploadExampleImage(MatFile, path);
                }    
               Commodity = await CommodityManager.Update(Commodity);
            }
            catch(Exception e)
            {
                // Awesome...
            }
            finally
            {
                var UpldateCommodity = Commodities.FirstOrDefault(e => e.Equals(Commodity));
                UpdateCommodity = Commodity; 
                UpdateDialogIsOpen = false;
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
            Img = "/images/" + ImgName;
        }
    }
}
