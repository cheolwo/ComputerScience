using Import.DataManager;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System.IO;
using Logistics.Service;
using System;
using System.Threading.Tasks;
using System.Linq;
using Logistics.ViewModel;
using Import.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;

namespace Logistics.Pages.ofCommodity
{
    /// <summary>
    /// File :
    /// </summary>
    public partial class Create
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] ICommodityDetailManager CommodityDetailManager {get; set;}
        [Inject] ICommodityFileManager FileManager { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        public CommodityModel commodityModel = new CommodityModel();
        public Commodity commodity = new Commodity();
        public CommodityDetail commodityDetail = new CommodityDetail();
        public string path { get; set; }
        public string ErrorMessage { get; set; }
        public EditContext EditContext { get; set; }

        [Parameter] public bool CreateDialogIsOpen {get; set;}
        [Parameter] public string CommodityNo { get; set; }  
        [Parameter] public EventCallback DialogSwitch {get; set;}
        [Parameter] public List<Commodity> Commodities { get; set; }

        protected override void OnInitialized()
        {
            EditContext = new EditContext(commodity);
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
   

        public async Task Add()
        {
            string Route;
            var isValid = EditContext.Validate();
            if (isValid)
            {              
                try
                {
                    // 상품등록
                    Route = await FileManager.UploadCommodityImage(MatFile);
                    commodity.ImageTitle = MatFile.Name;
                    commodity.ImageRoute = Route;
                    commodity = CommodityManager.Add(commodity);
                         
                    // 상품디테일 생성
                    commodityDetail.Commodity = commodity;
                    CommodityDetailManager.Add(commodityDetail);
                    NavigationManager.NavigateTo("/Get/Commodity", true);
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    
                    // Awesome....
                }
                finally
                {                  
                    CreateDialogIsOpen = false;
                }
            }
            else
            {

            }
        }
        
    }
}
