using Import.Model;
using MatBlazor;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public interface ICommodityFileManager
    {
        Task<string> UploadCommodityImage(IMatFileUploadEntry imageFile);
        Task UploadCommodityImage(IMatFileUploadEntry imageFile, string path);
        Task<List<string>> UploadOptionImage(IMatFileUploadEntry[] entries);
        Task<List<string>> UploadDetailImage(IMatFileUploadEntry[] entries);
        Task<string> UploadOptionImage(IMatFileUploadEntry entry);
        Task UploadOptionImage(IMatFileUploadEntry entry, string path);

        //void UpdateImageofOption(IMatFileUploadEntry entry, string path);

        Task DeleteOptionImageByCommodity(Commodity commodity);
        Task DeleteOptionImageByOptionNo(int optionNo);
        Task DeleteOptionImageByOption(Option option);
        Task DeleteDetailImageByCommodity(Commodity commodity);
       
        void DeleteCommodityImageByCommodity(Commodity commodity);

    }
}
