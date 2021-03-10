using Market.IDataManager.ofSCommodity;
using Market.Model;
using Market.Model.ofSCommodity;
using MatBlazor;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public class SCommodityFileManager : ISCommodityFileManager
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ISCommodityManager _commodityManager;
        private readonly IOptionManager _optionManager;
        private readonly IDetailofSCommodityManager _commodityDetailManager;
        private readonly IImageofDetailManager _imageofDetailManager;
        private readonly IImageofOptionManager _imageofOptionManager;

        public MemoryStream ms { get; set; }
        public string CommodityPath { get; set; }
        public string DetailPath { get; set; }
        public string OptionPath { get; set; }

        public SCommodityFileManager(IWebHostEnvironment environment, ISCommodityManager commodityManager,
            IOptionManager optionManager, IDetailofSCommodityManager commodityDetailManager,
            IImageofDetailManager imageofDetailManager, IImageofOptionManager imageofOptionManager)
        {
            _environment = environment;
            _commodityManager = commodityManager;
            _optionManager = optionManager;
            _commodityDetailManager = commodityDetailManager;
            _imageofDetailManager = imageofDetailManager;
            _imageofOptionManager = imageofOptionManager;

            ms = new MemoryStream();          
        }

        public async Task DeleteDetailImageByCommodity(SCommodity commodity)
        {
            List<Option> Options = await _optionManager.GetToListByCommodityAsync(commodity);

            foreach(var Option in Options)
            {
                Option.Images = _imageofOptionManager.GetToListByOption(Option);
                foreach(var Image in Option.Images)
                {
                    Image.ImagesofDetail = _imageofDetailManager.GetToListByImageofOption(Image);
                    foreach(var Detail in Image.ImagesofDetail)
                    {
                        File.Delete(Detail.ImageRoute);
                    }
                }
            }
        }

        public void DeleteCommodityImageByCommodity(SCommodity commodity)
        {
            string path = commodity.ImageRoute;
            File.Delete(path);
        }

        public void DeleteOptionImageByCommodity(SCommodity commodity)
        {
            List<Option> Options = _optionManager.GetToListByCommodity(commodity);
            foreach(var option in Options)
            {
                option.Images = _imageofOptionManager.GetToListByOption(option);
                foreach (var Image in option.Images)
                {
                    File.Delete(Image.ImageRoute);
                    foreach(var Detail in Image.ImagesofDetail)
                    {
                        File.Delete(Detail.ImageRoute);
                    }
                }
            }
        }
        
        // 하위삭제
        public void DeleteOptionImageByOption(Option option)
        {
            foreach (var Image in option.Images)
            {
                File.Delete(Image.ImageRoute);
                foreach(var Detail in Image.ImagesofDetail)
                {
                    File.Delete(Detail.ImageRoute);
                }
            }
        }

        public void DeleteOptionImageByOptionNo(int OptionNo)
        {
            Option option =  _optionManager.GetById(OptionNo);
            DeleteOptionImageByOption(option);
        }

        public async Task<string> UploadCommodityImage(IMatFileUploadEntry ImageFile)
        {
            if(ImageFile == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }

            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Commodity", ImageFile.Name);
        
            await ImageFile.WriteToStreamAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
        }

        public async Task UploadCommodityImage(IMatFileUploadEntry ImageFile, string path)
        {
            await ImageFile.WriteToStreamAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }

        public async Task<List<string>> UploadOptionImage(IMatFileUploadEntry[] entries)
        {
            string path;
            List<string> Paths = new List<string>();
            if (entries.Length > 0)
            {
                foreach (var entry in entries)
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Option", entry.Name);
                    await entry.WriteToStreamAsync(ms);
                    using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);
                    Paths.Add(path);
                }
            }
            return Paths;
        }
        public async Task UploadOptionImage(IMatFileUploadEntry[] entries, string path)
        {
            if (entries.Length > 0)
            {
                foreach (var entry in entries)
                {                    
                    await entry.WriteToStreamAsync(ms);
                    using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);                 
                }
           
            }
        }

        public async Task<List<string>> UploadDetailImage(IMatFileUploadEntry[] entries)
        {
            string path;
            List<string> Paths = new List<string>();
            if (entries.Length > 0)
            {
                foreach (var entry in entries)
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Detail", entry.Name);
                    await entry.WriteToStreamAsync(ms);
                    using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);
                    Paths.Add(path);
                }             
            }
            return Paths;
        }

        public async Task<string> UploadOptionImage(IMatFileUploadEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }

            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Option", entry.Name);

            await entry.WriteToStreamAsync(ms);
            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);

            return path;
        }

        public async Task UploadOptionImage(IMatFileUploadEntry entry, string path)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }
       
            await entry.WriteToStreamAsync(ms);
            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }

        void ISCommodityFileManager.DeleteDetailImageByCommodity(SCommodity commodity)
        {
            DetailofSCommodity commodityDetail = _commodityDetailManager.GetByCommodity(commodity);
            
            foreach(var image in commodityDetail.DetailImages)
            {
                File.Delete(image.ImageRoute);
            }
        }

        public async Task<string> UploadDetailImage(IMatFileUploadEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }

            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Detail", entry.Name);

            await entry.WriteToStreamAsync(ms);
            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);

            return path;
        }
    }
}
