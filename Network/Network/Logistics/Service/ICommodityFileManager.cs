using Import.Model;
using MatBlazor;
using System.Threading.Tasks;

namespace Logistics.Service
{
    public interface ICommodityFileManager
    {
        Task UploadExampleImage(IMatFileUploadEntry ImageFile);
        Task UploadExampleImage(IMatFileUploadEntry ImageFile, string path);
        Task UploadOptionImage(IMatFileUploadEntry[] entries);
        Task UploadDetailImage(IMatFileUploadEntry[] entries);
        Task UploadOptionImage(IMatFileUploadEntry entry);
        Task UploadOptionImage(IMatFileUploadEntry entry, string path);

        //void UpdateImageofOption(IMatFileUploadEntry entry, string path);

        Task DeleteOptionImage(Commodity commodity);
        Task DeleteOptionImageById(int OptionNo);
        Task DeleteOptionImageByEntity(Option option);
        Task DeleteDetailImage(Commodity commodity);
        Task DeleteDeatilImageById(int DetailNo);
        Task DeleteDetailImageByEntity(CommodityDetail commodityDetail);
        void DeleteExampleImage(Commodity commodity);

    }
}
