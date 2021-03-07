namespace Warehouse.IDataManager
{
 public interface IWarehouseDataManager
 {
   Warehouse Add(Warehouse warehouse);
   void DeleteById(int warehouseNo);
   void DeleteByWarehouse(Warehouse warehouse);
   Warehouse GetById(int warehouseNo);
   Warehouse Update(Warehouse warehouse);
   List<Warehouses> GetToList();
 }
  
 public interface IWCommodityDataManager
 {
     WCommodity Add(WCommodity wcommodity);
     void DeleteById(int wcommodityNo);
     void DeleteByWCommodity(WCommodity wcommodity);
     WCommodity GetById(int wcommodityNo);
     WCommodity Update(WCommodity warehouse);
     List<WCommodity> GetToList();
 }
  
 public interface DividedCommodityDataManager
 {
     DividedCommodity Add(DividedCommodity wcommodity);
     void DeleteById(int dividedCommodityNo);
     void DeleteByWCommodity(DividedCommodity dividedCommodity);
     DividedCommodity GetById(int dividedCommodityNo);
     DividedCommodity Update(DividedCommodity dividedCommodity);
     List<DividedCommodity> GetToList();
 }
  
 public interface ILoadFrameDataManager
 {
     LoadFrame Add(LoadFrame LoadFrame);
     void DeleteById(int LoadFrameNo);
     void DeleteByLoadFrame(LoadFrame LoadFrame);
     LoadFrame GetById(int LoadFrameNo);
     LoadFrame Update(LoadFrame LoadFrame);
     List<LoadFrame> GetToList();
 }
  
 public interface IImageofCommodityDataManager
 {
     ImageofCommodity Add(ImageofCommodity ImageofCommodity);
     void DeleteById(int ImageofCommodityNo);
     void DeleteByImageofCommodity(ImageofCommodity ImageofCommodity);
     ImageofCommodity GetById(int ImageofCommodityNo);
     ImageofCommodity Update(ImageofCommodity ImageofCommodity);
     List<ImageofCommodity> GetToList();
 }

 public interface IImageofIncomingDataManager
 {
     ImageofIncoming Add(ImageofIncoming ImageofIncoming);
     void DeleteById(int ImageofIncomingNo);
     void DeleteByImageofIncoming(ImageofIncoming ImageofIncoming);
     ImageofIncoming GetById(int ImageofIncomingNo);
     ImageofIncoming Update(ImageofIncoming ImageofIncoming);
     List<ImageofIncoming> GetToList();
 }
  
 public interface IImageofLoadingDataManager
 {
     ImageofLoading Add(ImageofLoading ImageofLoading);
     void DeleteById(int ImageofLoadingNo);
     void DeleteByImageofLoading(ImageofLoading ImageofLoading);
     ImageofLoading GetById(int ImageofLoadingNo);
     ImageofLoading Update(ImageofLoading ImageofLoading);
     List<ImageofLoading> GetToList();
 }

 public interface IOutgoingCommodityDataManager
 {
     OutgoingCommodity Add(OutgoingCommodity OutgoingCommodity);
     void DeleteById(int OutgoingCommodityNo);
     void DeleteByOutgoingCommodity(OutgoingCommodity OutgoingCommodity);
     OutgoingCommodity GetById(int OutgoingCommodityNo);
     OutgoingCommodity Update(OutgoingCommodity OutgoingCommodity);
     List<OutgoingCommodity> GetToList();
 }

 public interface IPackDataManager
 {
     Pack Add(Pack Pack);
     void DeleteById(int PackNo);
     void DeleteByPack(Pack Pack);
     Pack GetById(int PackNo);
     Pack Update(Pack Pack);
     List<Pack> GetToList();
 }

 public interface IImageofPackDataManager
 {
     ImageofPack Add(ImageofPack ImageofPack);
     void DeleteById(int ImageofPackNo);
     void DeleteByImageofPack(ImageofPack ImageofPack);
     ImageofPack GetById(int ImageofPackNo);
     ImageofPack Update(ImageofPack ImageofPack);
     List<ImageofPack> GetToList();
 }

 public interface IDividedTagDataManager
 {
     DividedTag Add(DividedTag DividedTag);
     void DeleteById(int DividedTagNo);
     void DeleteByDividedTag(DividedTag DividedTag);
     DividedTag GetById(int DividedTagNo);
     DividedTag Update(DividedTag DividedTag);
     List<DividedTag> GetToList();
 }

 public interface IIncomingTagDataManager
 {
     IncomingTag Add(IncomingTag IncomingTag);
     void DeleteById(int IncomingTagNo);
     void DeleteByIncomingTag(IncomingTag IncomingTag);
     IncomingTag GetById(int IncomingTagNo);
     IncomingTag Update(IncomingTag IncomingTag);
     List<IncomingTag> GetToList();
 }

 public interface IImageofOutgoingDataManager
 {
     ImageofOutgoing Add(ImageofOutgoing ImageofOutgoing);
     void DeleteById(int ImageofOutgoingNo);
     void DeleteByImageofOutgoing(ImageofOutgoing ImageofOutgoing);
     ImageofOutgoing GetById(int ImageofOutgoingNo);
     ImageofOutgoing Update(ImageofOutgoing ImageofOutgoing);
     List<ImageofOutgoing> GetToList();
 }

 public interface IImageofDeliveringDataManager
 {
     ImageofDelivering Add(ImageofDelivering ImageofDelivering);
     void DeleteById(int ImageofDeliveringNo);
     void DeleteByImageofDelivering(ImageofDelivering ImageofDelivering);
     ImageofDelivering GetById(int ImageofDeliveringNo);
     ImageofDelivering Update(ImageofDelivering ImageofDelivering);
     List<ImageofDelivering> GetToList();
 }
}
