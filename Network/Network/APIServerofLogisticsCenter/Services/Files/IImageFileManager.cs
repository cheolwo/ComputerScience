using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace APIServerofLogisticsCenter.Services.Files
{
    public interface IImageFileManager
    {
        Task<string> UploadImageofBase(IFormFile file);
        Task<string> UploadImageofDelivering(IFormFile file);
        Task<string> UploadImageofIncoming(IFormFile file);
        Task<string> UploadImageofLoading(IFormFile file);
        Task<string> UploadImageofOutgoing(IFormFile file);
        Task<string> UploadImageofPack(IFormFile file);
        Task<string> UploadImageofPacking(IFormFile file);
        Task<string> UploadImageofWCommodity(IFormFile file);

        void Delete(string path);
    }

    public class ImageFileManager : IImageFileManager
    {
        private readonly IWebHostEnvironment _environment;
        public MemoryStream ms { get; set; }

        public ImageFileManager(IWebHostEnvironment environment)
        {
            _environment = environment;

            ms = new MemoryStream();
        }

        public void Delete(string path)
        {
            File.Delete(path);
        }

        public async Task<string> UploadImageofBase(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Base", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofDelivering(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Delivering", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofIncoming(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Incoming", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofLoading(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Loading(", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofOutgoing(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Outgoing", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofPack(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Pack", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofPacking(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\Packing", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
        public async Task<string> UploadImageofWCommodity(IFormFile file)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Imagesof\\WCommodity", file.Name);

            await file.CopyToAsync(ms);

            using FileStream Ufile = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(Ufile);
            return path;
        }
    }
}