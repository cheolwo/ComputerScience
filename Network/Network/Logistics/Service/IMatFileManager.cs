using MatBlazor;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Service
{
    interface IMatFileManager
    {
        Task UploadAsync(IMatFileUploadEntry MatFile);
    }

    public class MatFileManager : IMatFileManager
    {
        private readonly IWebHostEnvironment _environment;

        public MatFileManager(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task UploadAsync(IMatFileUploadEntry MatFile)
        {
            var path = Path.Combine(_environment.ContentRootPath, "File", MatFile.Name);
            var ms = new MemoryStream();
            await MatFile.WriteToStreamAsync(ms);

            using (FileStream Stream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(Stream);
            }
        }
    }
}
