using System.Collections.Generic;
using Warehouse.Model;

namespace Warehouse.IDataManager
{
 public interface IBaseManager
    {
   Base Add(Base Warehouse);
   void DeleteById(int WarehouseNo);
   void DeleteByWarehouse(Base Warehouse);
        Base GetById(int WarehouseNo);
        Base Update(Base Warehouse);
   List<Base> GetToList();
 }
  
 public interface IWCommodityManager
 {
     WCommodity Add(WCommodity WCommodity);
     void DeleteById(int WCommodityNo);
     void DeleteByWCommodity(WCommodity WCommodity);
     WCommodity GetById(int WCommodityNo);
     WCommodity Update(WCommodity WCommodity);
     List<WCommodity> GetToList();
 }
  
 public interface DividedCommodityManager
 {
     DividedCommodity Add(DividedCommodity DividedCommodity);
     void DeleteById(int dividedCommodityNo);
     void DeleteByDividedCommodity(DividedCommodity dividedCommodity);
     DividedCommodity GetById(int dividedCommodityNo);
     DividedCommodity Update(DividedCommodity dividedCommodity);
     List<DividedCommodity> GetToList();
 }
  
 public interface ILoadFrameManager
 {
     LoadFrame Add(LoadFrame LoadFrame);
     void DeleteById(int LoadFrameNo);
     void DeleteByLoadFrame(LoadFrame LoadFrame);
     LoadFrame GetById(int LoadFrameNo);
     LoadFrame Update(LoadFrame LoadFrame);
     List<LoadFrame> GetToList();
 }
  
 public interface IImageofCommodityManager
 {
     ImageofWCommodity Add(ImageofWCommodity ImageofCommodity);
     void DeleteById(int ImageofCommodityNo);
     void DeleteByImageofCommodity(ImageofWCommodity ImageofCommodity);
     ImageofWCommodity GetById(int ImageofCommodityNo);
     ImageofWCommodity Update(ImageofWCommodity ImageofCommodity);
     List<ImageofWCommodity> GetToList();
 }

 public interface IImageofIncomingManager
 {
     ImageofIncoming Add(ImageofIncoming ImageofIncoming);
     void DeleteById(int ImageofIncomingNo);
     void DeleteByImageofIncoming(ImageofIncoming ImageofIncoming);
     ImageofIncoming GetById(int ImageofIncomingNo);
     ImageofIncoming Update(ImageofIncoming ImageofIncoming);
     List<ImageofIncoming> GetToList();
 }
  
 public interface IImageofLoadingManager
 {
     ImageofLoading Add(ImageofLoading ImageofLoading);
     void DeleteById(int ImageofLoadingNo);
     void DeleteByImageofLoading(ImageofLoading ImageofLoading);
     ImageofLoading GetById(int ImageofLoadingNo);
     ImageofLoading Update(ImageofLoading ImageofLoading);
     List<ImageofLoading> GetToList();
 }

 public interface IOutgoingCommodityManager
 {
     OutgoingCommodity Add(OutgoingCommodity OutgoingCommodity);
     void DeleteById(int OutgoingCommodityNo);
     void DeleteByOutgoingCommodity(OutgoingCommodity OutgoingCommodity);
     OutgoingCommodity GetById(int OutgoingCommodityNo);
     OutgoingCommodity Update(OutgoingCommodity OutgoingCommodity);
     List<OutgoingCommodity> GetToList();
 }

 public interface IPackManager
 {
     Pack Add(Pack Pack);
     void DeleteById(int PackNo);
     void DeleteByPack(Pack Pack);
     Pack GetById(int PackNo);
     Pack Update(Pack Pack);
     List<Pack> GetToList();
 }

 public interface IImageofPackManager
 {
     ImageofPack Add(ImageofPack ImageofPack);
     void DeleteById(int ImageofPackNo);
     void DeleteByImageofPack(ImageofPack ImageofPack);
     ImageofPack GetById(int ImageofPackNo);
     ImageofPack Update(ImageofPack ImageofPack);
     List<ImageofPack> GetToList();
 }

 public interface IDividedTagManager
 {
     DividedTag Add(DividedTag DividedTag);
     void DeleteById(int DividedTagNo);
     void DeleteByDividedTag(DividedTag DividedTag);
     DividedTag GetById(int DividedTagNo);
     DividedTag Update(DividedTag DividedTag);
     List<DividedTag> GetToList();
 }

 public interface IIncomingTagManager
 {
     IncomingTag Add(IncomingTag IncomingTag);
     void DeleteById(int IncomingTagNo);
     void DeleteByIncomingTag(IncomingTag IncomingTag);
     IncomingTag GetById(int IncomingTagNo);
     IncomingTag Update(IncomingTag IncomingTag);
     List<IncomingTag> GetToList();
 }

 public interface IImageofOutgoingManager
 {
     ImageofOutgoing Add(ImageofOutgoing ImageofOutgoing);
     void DeleteById(int ImageofOutgoingNo);
     void DeleteByImageofOutgoing(ImageofOutgoing ImageofOutgoing);
     ImageofOutgoing GetById(int ImageofOutgoingNo);
     ImageofOutgoing Update(ImageofOutgoing ImageofOutgoing);
     List<ImageofOutgoing> GetToList();
 }

 public interface IImageofDeliveringManager
 {
     ImageofDelivering Add(ImageofDelivering ImageofDelivering);
     void DeleteById(int ImageofDeliveringNo);
     void DeleteByImageofDelivering(ImageofDelivering ImageofDelivering);
     ImageofDelivering GetById(int ImageofDeliveringNo);
     ImageofDelivering Update(ImageofDelivering ImageofDelivering);
     List<ImageofDelivering> GetToList();
 }
}
