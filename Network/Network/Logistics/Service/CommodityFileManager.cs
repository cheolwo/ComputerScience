using Import.DataManager;
using Import.Model;
using MatBlazor;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public class CommodityFileManager : ICommodityFileManager
    {
        private readonly IWebHostEnvironment _environment;
        private readonly ICommodityManager _commodityManager;
        private readonly IOptionManager _optionManager;
        private readonly ICommodityDetailManager _commodityDetailManager;
        private readonly IImageofDetailManager _imageofDetailManager;
        private readonly IImageofOptionManager _imageofOptionManager;

        public MemoryStream ms { get; set; }
        //public string ExamplePath { get; set; }
        //public string DetailPath { get; set; }
        //public string OptionPath { get; set; }

        public CommodityFileManager(IWebHostEnvironment environment, ICommodityManager commodityManager,
            IOptionManager optionManager, ICommodityDetailManager commodityDetailManager,
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

        public void DeleteDeatilImageById(int DetailNo)
        {
            var Entity = _commodityManager.GetById(DetailNo);
            
            if(Entity == null) { throw new ArgumentNullException("ENTITY_IS_NULL"); }
            List<ImageofDetail> ImageofDetails = _imageofDetailManager.GetByCommodityToList(Entity);

            if (ImageofDetails.Count == 0) { throw new ArgumentNullException("LIST_IS_EMPTY"); }

            foreach(var Image in ImageofDetails)
            {
                File.Delete(Image.ImageRoute);
            }
        }

        public Task DeleteDetailImage(Commodity commodity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDetailImageByEntity(CommodityDetail commodityDetail)
        {
            throw new NotImplementedException();
        }

        public void DeleteExampleImage(Commodity commodity)
        {
            string path = commodity.ImageRoute;
            File.Delete(path);
        }

        public Task DeleteOptionImage(Commodity commodity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOptionImageByEntity(Option option)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOptionImageById(int OptionNo)
        {
            throw new NotImplementedException();
        }

        public async Task UploadExampleImage(IMatFileUploadEntry ImageFile)
        {
            if(ImageFile == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }

            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Example", ImageFile.Name);
        
            await ImageFile.WriteToStreamAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }

        public async Task UploadExampleImage(IMatFileUploadEntry ImageFile, string path)
        {
            await ImageFile.WriteToStreamAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }

        public async Task UploadOptionImage(IMatFileUploadEntry[] entries)
        {
            string path;
            if (entries.Length > 0)
            {
                foreach (var entry in entries)
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Option", entry.Name);
                    await entry.WriteToStreamAsync(ms);
                    using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);
                }
            }
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

        public async Task UploadDetailImage(IMatFileUploadEntry[] entries)
        {
            string path;
            if (entries.Length > 0)
            {
                foreach (var entry in entries)
                {
                    path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Detail", entry.Name);
                    await entry.WriteToStreamAsync(ms);
                    using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
                    ms.WriteTo(file);
                }
            }
        }

        Task ICommodityFileManager.DeleteDeatilImageById(int DetailNo)
        {
            throw new NotImplementedException();
        }

        public async Task UploadOptionImage(IMatFileUploadEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }

            var path = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images\\Option", entry.Name);

            await entry.WriteToStreamAsync(ms);
            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
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
    }
}
