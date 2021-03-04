using Import.DataManager;
using Import.Model;
using Logistics.Service;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Logistics.Pages.ofOption
{
    public partial class Update
    {
        [Inject] IOptionManager OptionManager {get; set;}
        [Inject] ICommodityFileManager FileManager {get; set;}
        [Inject] IImageofOptionManager ImageofOptionManager {get; set;}
        [Inject] IWebHostEnvironment WebHostEnvironment {get; set;}
        
        [Parameter] public string OptionNo {get; set;}
        
        public Dictionary<int, IMatFileUploadEntry> Images = new Dictionary<int, IMatFileUploadEntry>();
        public List<int> ImageofOptionNos = new List<int>();
        public Option UpdateOption = new Option();
            
        protected override void OnInitialized()
        {
            UpdateOption = OptionManager.GetById(Convert.ToInt32(OptionNo));
            UpdateOption.Images = ImageofOptionManager.GetByOptionToList(UpdateOption);
        }
        
        public void FileUpload(int ImageofOptionNo, IMatFileUploadEntry File)
        {
            if (File != null)
            {
                Images.Add(ImageofOptionNo, File);
                ImageofOptionNos.Add(ImageofOptionNo);
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
        
        //public void Update(Dictionary<int, IMatFileUploadEntry> Images, List<int> ImageofOptionNos)
        //{            
        //    OptionManager.Update(UpdateOption);
        //    FileUpldate(Images, ImageofOptionNos);
        //    UpdateOption.Images = ImageofOptionManager.GetByOption(UpdateOption);
        //}
        
        public void Reset()
        {
            // UpdateOption.... null
            
            Images.Clear();
            ImageofOptionNos.Clear();
            
        }
        
    }
}
