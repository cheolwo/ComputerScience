using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public interface IFileManager
    {
        Task UploadAsync(IFileListEntry file);
    }

    public class FileManager : IFileManager
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IConfiguration _configuration;

        public FileManager(IWebHostEnvironment environment, IConfiguration configuration)
        {
            _environment = environment;
            _configuration = configuration;
        }

        //C:\Users\user\Desktop\ComputerScience\Network\Network\Logistics\Logistics.csproj
        public async Task UploadAsync(IFileListEntry file)
        {
            var Path = _environment.ContentRootPath + "\\File\\" + file.Name;
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            using (FileStream SaveFile = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(SaveFile);
            }
        }
    }


}
