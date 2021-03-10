using Logistics.Service;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Pages.ofSCommodity
{
    public partial class Update
    {
        
        [Inject] public ISCommodityManager CommodityManager { get; set; }
        [Inject] public ISCommodityFileManager FileManager { get; set; }
        [Inject] public IWebHostEnvironment Environment { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        
        [Parameter] public int CommodityNo { get; set; }
        [Parameter] public bool UpdateDialogIsOpen {get; set;}
        [Parameter] public List<SCommodity> Commodities {get; set;}
        [Parameter] public EventCallback DialogSwitch {get; set;}

        public IMatFileUploadEntry MatFile { get; set; }

        public SCommodity Commodity = new SCommodity();
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

        public void ReadFile(SCommodity commodity)
        {
            ImgName = commodity.ImageTitle;
            Img = "/images/Commodity/" + ImgName;
        }
    }
}
