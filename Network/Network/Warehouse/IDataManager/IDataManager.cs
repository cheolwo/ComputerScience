using System.Collections.Generic;
using Warehouse.Model;

namespace Warehouse.IDataManager
{
 public interface IBaseManager
    {
   Base Add(Base Warehouse);
   void DeleteById(int Id);
   void DeleteByBase(Base Warehouse);
        Base GetById(int Id);
        Base Update(Base Warehouse);
   List<Base> GetToList();
 }
  
 public interface IWCommodityManager
 {
     WCommodity Add(WCommodity WCommodity);
     void DeleteById(int Id);
     void DeleteByWCommodity(WCommodity WCommodity);
     WCommodity GetById(int Id);
     WCommodity Update(WCommodity WCommodity);
     List<WCommodity> GetToList();
 }
  
 public interface IDividedCommodityManager
 {
     DividedCommodity Add(DividedCommodity DividedCommodity);
     void DeleteById(int Id);
     void DeleteByDividedCommodity(DividedCommodity dividedCommodity);
     DividedCommodity GetById(int Id);
     DividedCommodity Update(DividedCommodity dividedCommodity);
     List<DividedCommodity> GetToList();
 }
  
 public interface ILoadFrameManager
 {
     LoadFrame Add(LoadFrame LoadFrame);
     void DeleteById(int Id);
     void DeleteByLoadFrame(LoadFrame LoadFrame);
     LoadFrame GetById(int Id);
     LoadFrame Update(LoadFrame LoadFrame);
     List<LoadFrame> GetToList();
 }
  
 public interface IImageofWCommodityManager
 {
     ImageofWCommodity Add(ImageofWCommodity ImageofCommodity);
     void DeleteById(int Id);
     void DeleteByImageofWCommodity(ImageofWCommodity ImageofCommodity);
     ImageofWCommodity GetById(int Id);
     ImageofWCommodity Update(ImageofWCommodity ImageofCommodity);
     List<ImageofWCommodity> GetToList();
 }

 public interface IImageofIncomingManager
 {
     ImageofIncoming Add(ImageofIncoming ImageofIncoming);
     void DeleteById(int Id);
     void DeleteByImageofIncoming(ImageofIncoming ImageofIncoming);
     ImageofIncoming GetById(int Id);
     ImageofIncoming Update(ImageofIncoming ImageofIncoming);
     List<ImageofIncoming> GetToList();
 }
  
 public interface IImageofLoadingManager
 {
     ImageofLoading Add(ImageofLoading ImageofLoading);
     void DeleteById(int Id);
     void DeleteByImageofLoading(ImageofLoading ImageofLoading);
     ImageofLoading GetById(int Id);
     ImageofLoading Update(ImageofLoading ImageofLoading);
     List<ImageofLoading> GetToList();
 }

 public interface IOutgoingCommodityManager
 {
     OutgoingCommodity Add(OutgoingCommodity OutgoingCommodity);
     void DeleteById(int Id);
     void DeleteByOutgoingCommodity(OutgoingCommodity OutgoingCommodity);
     OutgoingCommodity GetById(int Id);
     OutgoingCommodity Update(OutgoingCommodity OutgoingCommodity);
     List<OutgoingCommodity> GetToList();
 }

 public interface IPackManager
 {
     Pack Add(Pack Pack);
     void DeleteById(int Id);
     void DeleteByPack(Pack Pack);
     Pack GetById(int Id);
     Pack Update(Pack Pack);
     List<Pack> GetToList();
 }

 public interface IImageofPackManager
 {
     ImageofPack Add(ImageofPack ImageofPack);
     void DeleteById(int Id);
     void DeleteByImageofPack(ImageofPack ImageofPack);
     ImageofPack GetById(int Id);
     ImageofPack Update(ImageofPack ImageofPack);
     List<ImageofPack> GetToList();
 }

 public interface IDividedTagManager
 {
     DividedTag Add(DividedTag DividedTag);
     void DeleteById(int Id);
     void DeleteByDividedTag(DividedTag DividedTag);
     DividedTag GetById(int Id);
     DividedTag Update(DividedTag DividedTag);
     List<DividedTag> GetToList();
 }

 public interface IIncomingTagManager
 {
     IncomingTag Add(IncomingTag IncomingTag);
     void DeleteById(int Id);
     void DeleteByIncomingTag(IncomingTag IncomingTag);
     IncomingTag GetById(int Id);
     IncomingTag Update(IncomingTag IncomingTag);
     List<IncomingTag> GetToList();
 }

 public interface IImageofOutgoingManager
 {
     ImageofOutgoing Add(ImageofOutgoing ImageofOutgoing);
     void DeleteById(int Id);
     void DeleteByImageofOutgoing(ImageofOutgoing ImageofOutgoing);
     ImageofOutgoing GetById(int Id);
     ImageofOutgoing Update(ImageofOutgoing ImageofOutgoing);
     List<ImageofOutgoing> GetToList();
 }

 public interface IImageofDeliveringManager
 {
     ImageofDelivering Add(ImageofDelivering ImageofDelivering);
     void DeleteById(int Id);
     void DeleteByImageofDelivering(ImageofDelivering ImageofDelivering);
     ImageofDelivering GetById(int Id);
     ImageofDelivering Update(ImageofDelivering ImageofDelivering);
     List<ImageofDelivering> GetToList();
 }
}
