namespace APIWarehouse.ViewModel
{
    public class Warehouse
   {
       [Key] public int Id { get; set; }
       public string UserId {get; set;}  // 배송 및 물류대행업체
       public string Address { get; set; }
       public Country Country { get; set; }

       public List<ImageofWarehouse> ImagesofWarehouse {get; set;}
       public List<WCommodity> WCommodities { get; set; }
       public List<LoadFrame> LoadFrmaes { get; set; }
   }
}

public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
{
    long size = files.Sum(f => f.Length);

    foreach (var formFile in files)
    {
        if (formFile.Length > 0)
        {
            var filePath = Path.GetTempFileName();

            using (var stream = System.IO.File.Create(filePath))
            {
                await formFile.CopyToAsync(stream);
            }
        }
    }

    foreach (var formFile in files)
{
    if (formFile.Length > 0)
    {
        var filePath = Path.Combine(_config["StoredFilesPath"], 
            Path.GetRandomFileName());

        using (var stream = System.IO.File.Create(filePath))
        {
            await formFile.CopyToAsync(stream);
        }
    }
}

    // Process uploaded files
    // Don't rely on or trust the FileName property without validation.

    return Ok(new { count = files.Count, size });
}