﻿using Import.DataManager;
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

namespace Logistics.Pages.ofCommodity
{
    /// <summary>
    /// File :
    /// </summary>
    public partial class Create
    {
        [Inject] ICommodityManager CommodityManager { get; set; }
        [Inject] ICommodityDetailManager CommodityDetailManager {get; set;}
        [Inject] ICommodityFileManager CommodityFileManager { get; set; }
        [Inject] IWebHostEnvironment _environment { get; set; }

        public CommodityModel commodityModel = new CommodityModel();
        public Commodity commodity = new Commodity();
        public CommodityDetail commodityDetail = new CommodityDetail();
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
            commodityModel.Import = null;
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
                path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images", commodityModel.MatFile.Name);

                try
                {
                    // 상품등록
                    await MatFileUpload(commodityModel, path);
                    ViewModelToModel(commodityModel, commodity, path);
                    commodity = CommodityManager.AddAsync(commodity);
                    
                    // 상품등록 목적확인
                    if(commodityModel.Import.Equal(Import.Import)) { commodityDetail.ImportDefaultValue(); }
                    else { commodityDetal.AgencyDefaultValue(); }
                    
                    // 상품디테일 기본값 생성
                    commodityDetail.Commodity = commodity;
                    await CommodityDetailManger.Add(commodityDetail);
                }
                catch (Exception e)
                {
                    ErrorMessage = e.Message;
                    
                    // Awesome....
                }
                finally
                {
                    Reset(commodityModel);
                }
            }
            else
            {

            }
        }
    }
}
