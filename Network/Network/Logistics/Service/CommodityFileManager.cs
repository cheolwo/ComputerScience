using MatBlazor;
using Microsoft.AspNetCore.Hosting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public class CommodityFileManager : ICommodityFileManager
    {
        private readonly IWebHostEnvironment _environment;

        public CommodityFileManager(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task UploadExampleImage(IMatFileUploadEntry ImageFile)
        {
            if(ImageFile == null)
            {
                throw new ArgumentNullException("FILE_NULL");
            }

            var path = Path.Combine(_environment.ContentRootPath, "File\\Commodity", ImageFile.Name);

            var ms = new MemoryStream();
            await ImageFile.WriteToStreamAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }

        public async Task UploadExampleImage(IMatFileUploadEntry ImageFile, string path)
        {
            var ms = new MemoryStream();
            await ImageFile.WriteToStreamAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }
    }
}
