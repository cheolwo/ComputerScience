using Import.DataManager;
using Import.ImportDataContext;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Drawing;
using Logistics.Service;
using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;
using System.Linq;
using Logistics.ViewModel;
using Import.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Forms;

namespace Logistics.Pages.ofCommodity
{
    /// <summary>
    /// File :
    /// </summary>
    public partial class Create
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] ICommodityFileManager CommodityFileManager { get; set; }
        [Inject] IWebHostEnvironment _environment { get; set; }

        public CommodityModel commodityModel = new CommodityModel();
        public Commodity commodity = new Commodity();
        public string path { get; set; }
        public string ErrorMessage { get; set; }
        public EditContext EditContext { get; set; }

        [Parameter] public string CommodityNo { get; set; }

        protected override void OnInitialized()
        {
            EditContext = new EditContext(commodityModel);
        }

        public void Reset(CommodityModel commodityModel)
        {
            commodityModel.Name = null;
            commodityModel.Category = null;
            commodityModel.Url = null;
            commodityModel.MatFile = null;
        }

        public IMatFileUploadEntry MatFile { get; set; }

        public void UploadToBuffer(IMatFileUploadEntry[] MatFiles)
        {
            MatFile = MatFiles.FirstOrDefault();

            if (MatFile != null)
            {
                commodityModel.MatFile = MatFile;
            }
        }

        public void ViewModelToModel(CommodityModel commodityModel, Commodity commodity, string path)
        {
            commodity.Category = commodityModel.Category;
            commodity.Name = commodityModel.Name;
            commodity.Url = commodityModel.Url;
            commodity.ImageRoute = path;
            
            if(commodityModel.MatFile != null)
            {
                commodity.ImageTitle = commodityModel.MatFile.Name;
            }        
        }
    
        public async Task MatFileUpload(CommodityModel commodityModel, string path)
        {
            if(commodityModel.MatFile != null )
            {
                await CommodityFileManager.UploadExampleImage(commodityModel.MatFile, path);
            }         
        }

        public async Task Add()
        {
            var isValid = EditContext.Validate();
            if (isValid)
            {
                path = Path.Combine(_environment.ContentRootPath, "File\\Commodity", commodityModel.MatFile.Name);

                try
                {
                    await MatFileUpload(commodityModel, path);
                    ViewModelToModel(commodityModel, commodity, path);
                    await CommodityManager.AddAsync(commodity);

                    Reset(commodityModel);
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                }
            }
            else
            {

            }
        }
    }
}