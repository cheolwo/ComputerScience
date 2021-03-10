using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Components.Forms;
using Market.IDataManager.ofSCommodity;
using Logistics.Service;
using Market.Model.ofSCommodity;

namespace Logistics.Pages.ofOption
{
    public partial class Update
    {
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] ISCommodityFileManager FileManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        [Inject] IWebHostEnvironment WebHostEnvironment {get; set;}
        [Inject] IImageofDetailManager ImageofDetailManager {get; set;}

        [Parameter] public string OptionNo {get; set;}
        public List<IMatFileUploadEntry> ImageofOptionFiles = new List<IMatFileUploadEntry>();
        public List<IMatFileUploadEntry> ImageofDetailFiles = new List<IMatFileUploadEntry>();
        public Option UpdateOption = new Option();

        public EditContext EditContext {get; set;}
        public bool UpdateDialogIsOpen { get; set; }
            
        protected override void OnInitialized()
        {
            UpdateOption = OptionManager.GetById(Convert.ToInt32(OptionNo));
            UpdateOption.Images = ImageofOptionManager.GetToListByOption(UpdateOption);

            foreach(var Image in UpdateOption.Images)
            {
                Image.ImagesofDetail = ImageofDetailManager.GetToListByImageofOption(Image);
            }
            
            EditContext = new EditContext(UpdateOption);
        }

       /// Clear() 중복 업로드 방지 
        public void FileUploadofImageofOption(IMatFileUploadEntry[] Files)
        {
            ImageofOptionFiles.Clear();  
            if (Files != null)
            {
                foreach(var File in Files)
                {
                    ImageofOptionFiles.Add(File);
                }
            }
        }

        /// Clear() 중복 업로드 방지
        public void FileUploadofImageofDeatil(IMatFileUploadEntry[] Files)
        {
            ImageofDetailFiles.Clear(); 
            if (Files != null)
            {
                foreach (var File in Files)
                {
                    ImageofDetailFiles.Add(File);
                }
            }
        }

        // 기존 파일 삭제 후 추가 및 데이터 수정
        // Option 데이터 OnInitialized 할 때 채움.
        public async void UploadDataAndImageofOptionInDialog()
        {
            bool Validate = EditContext.Validate();
            ImageofOption imageofOption = new ImageofOption();
            string route;
            
            if(Validate)
            {
                try
                {
                    if(ImageofOptionFiles != null)
                    {
                        FileManager.DeleteOptionImageByOption(UpdateOption);         // 파일 하위삭제
                        await ImageofOptionManager.DeleteByOption(UpdateOption);     // 데이터 하위삭제

                        UpdateOption.Images = null;                                  // 기존 데이터와 관계단절
                        var option = OptionManager.Update(UpdateOption);             // 데이터 수정

                        foreach(var File in ImageofOptionFiles)                      
                        {
                            route = await FileManager.UploadOptionImage(File);             // 이미지 업로드
                            imageofOption.ImageTitle = File.Name;
                            imageofOption.ImageRoute = route;
                            imageofOption.Option = option;
                            await ImageofOptionManager.AddAsync(imageofOption);      // 이미지 경로 저장   
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
                    UpdateDialogIsOpen = false;
                }
            }
        }
        
        public void FileUpdate(Dictionary<int, IMatFileUploadEntry> Images, List<int> Nos)
        {
            if (Nos.Count > 0)
            {
                foreach(var No in Nos)
                {
                    // 기존 이미지 삭제
                    var Image = ImageofOptionManager.GetById(No);
                    File.Delete(Image.ImageRoute);

                    var UploadFile = Images[No];
                    Image.ImageTitle = UploadFile.Name;
                    Image.ImageRoute = Path.Combine(WebHostEnvironment.ContentRootPath, "wwwroot\\Options", Image.ImageTitle);     
                    
                    // 파일 업로드
                    FileManager.UploadOptionImage(UploadFile, Image.ImageRoute);

                    // 이미지 경로 업데이트
                    ImageofOptionManager.Update(Image);
                }
            }
            
            Reset();                      
        }
        
        public void Reset()
        {
            ImageofOptionFiles.Clear();
            UpdateOption.SCommodity = null;
           /// UpdateOption.CommotityBarcode = null;
            UpdateOption.Images = null;
           // UpdateOption.ModelNo = null;
            UpdateOption.Key = null;
          //  UpdateOption.NormalPrice = null;
            UpdateOption.Id = 0;
           // UpdateOption.Quantity = 0;
           // UpdateOption.SalePrice = null;
           // UpdateOption.SellerCodeofCommodity = null;
            UpdateOption.Value = null;
        }
        
    }
}
