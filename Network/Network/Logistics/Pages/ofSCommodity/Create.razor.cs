using MatBlazor;
using Microsoft.AspNetCore.Components;
using Logistics.Service;
using System;
using System.Threading.Tasks;
using System.Linq;
using Logistics.ViewModel;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;

namespace Logistics.Pages.ofSCommodity
{
    /// <summary>
    /// File :
    /// </summary>
    public partial class Create
    {
        [Inject] ISCommodityManager SCommodityManager { get; set; }
        [Inject] IDetailofSCommodityManager DetailofSCommodityManager {get; set;}
        [Inject] ISCommodityFileManager FileManager { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }

        public CommodityModel commodityModel = new CommodityModel();
        public SCommodity commodity = new SCommodity();
        public DetailofSCommodity DetailofSCommodity = new DetailofSCommodity();
        public string path { get; set; }
        public string ErrorMessage { get; set; }
        public EditContext EditContext { get; set; }

        [Parameter] public bool CreateDialogIsOpen {get; set;}
        [Parameter] public string CommodityNo { get; set; }  
        [Parameter] public EventCallback DialogSwitch {get; set;}
        [Parameter] public List<SCommodity> Commodities { get; set; }

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
                    commodity = SCommodityManager.Add(commodity);
                         
                    // 상품디테일 생성
                    DetailofSCommodity.SCommodity = commodity;
                    DetailofSCommodityManager.Add(DetailofSCommodity);
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
                CreateDialogIsOpen = false;
            }
        }
        
    }
}
