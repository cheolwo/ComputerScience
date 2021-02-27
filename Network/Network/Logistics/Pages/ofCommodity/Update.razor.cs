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
        [Parameter] public string CommodityNo { get; set; }
        [Inject] public ICommodityManager CommodityManager { get; set; }
        [Inject] public ICommodityFileManager FileManager { get; set; }
        [Inject] public IWebHostEnvironment Environment { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        public IMatFileUploadEntry MatFile { get; set; }

        public Commodity Commodity { get; set; }
        public string ImgName { get; set; }
        public string Img { get; set; }

        protected override void OnInitialized()
        {
            Commodity = CommodityManager.GetById(Convert.ToInt32(CommodityNo));
            ReadFile(Commodity);
        }

        public void UpdateCommodity()
        {
            if(MatFile != null)
            {
                string path = Path.Combine(Environment.ContentRootPath, "wwwroot\\Images", MatFile.Name);
                File.Delete(Commodity.ImageRoute);
                Commodity.ImageRoute = path;
                Commodity.ImageTitle = MatFile.Name;
                FileManager.UploadExampleImage(MatFile, path);
            }    
            CommodityManager.Update(Commodity);
            NavigationManager.NavigateTo("/Get/Commodity");
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
