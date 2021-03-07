public interface IWarehouseFileManager
{
    Task<string> UploadImageofWCommodity(IMatFileUploadEntry Image);
    Task<string> UploadImageofIncoming(IMatFileUploadEntry Image);
    Task<string> UploadImageofLoading(IMatFileUploadEntry Image);
    Task<string> UploadImageofPacking(IMatFileUploadEntry Image);
    Task<string> UploadImageofOutgoing(IMatFileUploadEntry Image);
    Task<string> UploadImageofDelivering(IMatFileUploadEntry Image);

    Task DeleteImageofWCommodity(string Name);
    Task DeleteImageofIncoming(string Name);
    Task DeleteImageofLoading(string Name);
    Task DeleteImageofPacking(string Name);
    Task DeleteImageofOutgoing(string Name);
    Task DeleteImageofDelivering(string Name);
}