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
    
    public Task<string> UploadImageofBase(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Base", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
    public Task<string> UploadImageofDelivering(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Delivering", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;        
    }
    public Task<string> UploadImageofIncoming(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Incoming", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
    public Task<string> UploadImageofLoading(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Loading(", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
    public Task<string> UploadImageofOutgoing(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Outgoing", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
    public Task<string> UploadImageofPack(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Pack", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
    public Task<string> UploadImageofPacking(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\Packing", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
    public Task<string> UploadImageofWCommodity(IFormFile file)
    {
        var path = Path.Combine(_environment.WebRootPath, "Imagesof\\WCommodity", file.Name);

        await file.CopyToAsync(ms);

            using FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
            return path;
    }
}