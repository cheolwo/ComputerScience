using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
   public class Warehouse
   {
       [Key] public int WarehouseNo { get; set; }
       public string UserNo {get; set;}  // 배송 및 물류대행업체
       public string Address { get; set; }
       public Country Country { get; set; }

       pub lic List<WCommodity> WCommodities { get; set; }
       public List<LoadFrmae> LoadFrmaes { get; set; }
   }

   public enum Country { Korea = 1, China = 2, Japan = 3, Russia = 4, America = 5 }

   // Load 기획 필요
   // 입고신청 기능 필요

   public class WCommodity
   {
       [Key] public int WCommodityNo { get; set; }
       public string OwnUser {get; set;} // 물건 주인
       public string Name { get; set; }
       public float? Width {get; set;}
       public float? height {get; set;}
       public float? length {get set;}
       
       public StateofIncoming StateofIncoming { get; set; }
       public DateTime? IncomingTime { get; set; }
       public DateTime? InspectingTime { get; set; }
       public DateTime? LoadingTime { get; set; }

       // 책임 사람
       public string IncomingUser {get; set;}
       public string InspectingUser {get; set;}

       public int IncomingQuantity { get; set; }
       public int OutgoingQuantity {get; set;}
       public string TagfCommodity { get; set; }

       public List<ImageofWCommodity> ImagesofWCommodity { get; set; }
       public List<ImageofIncoming> ImagesofIncoming { get; set; }
           
       public Warehouse Warehouse { get; set; }
       public List<DividedCommodity> DividedCommodities { get; set; }
       public List<OutgoingCommodity> OutgoingCommodities {get; set;}
   }

   public enum StateofIncoming { Waiting = 1, Inspecting = 2, Returing = 3, Loading = 4 }

   public class DividedCommodity           
   {
       [Key] public int DivideCommodityNo { get; set; }
       public string TagfDividing { get; set; }
       public int Quantity { get; set; }

       public LoadFrame LoadFrmae { get; set; }
       public WCommodity WCommodity { get; set; }
       public List<ImageofLoading> ImagesofLoading {get; set;}
   }

   // 주문이 들어오면 창고에서 출고할 수 있도록 데이터 구조를 만들어두어야돼.
   // 판매상품을 들고하기 전에 WCommodityNo가 저장되도록 만들 필요가 있어.

   public class OutgoingCommodity
   {
       [Key] public int OutgoingCommodityNo {get; set;}
       public int OrderNo {get; set;}
       public int Quantity {get; set;}
       public StateofOutgoing StateofOutgoing {get; set;}

       // 책임사람
        public DateTime? WaitingTime {get; set;}
        public DateTime? PickingTime {get; set;}
        public DateTime? PackingTime {get; set;}
        public DateTime? OutgoingTime {get; set;}
        public DateTime? DeliveringTime {get; set;}

       public string PickingUser {get; set;}
       public string PackingUser {get; set;}
       public string OutgoingUser {get; set;}
       public string DeliveringUser {get; set;}

       public Pack Pack {get; set;}
       public List<ImageofPacking> ImagesofPacking {get; set;}
       public List<ImageofOutgoing> ImagesofOutgoing {get; set;}
       public List<ImageofDelivering> ImagesofDelivering {get; set;}
       public WCommodity WCommodity {get; set;}
   }

   public class Pack
   {
       [Key] public string PackName {get; set;}
       public string Material {get; set;}
       public float? Width {get; set;}
       public float? height {get; set;}
       public float? length {get set;}

       public List<ImageofPack> ImagesofPack {get; set;}
   }

   public class ImageofPack
   {
       [Key] public int ImageofPackNo {get; set;}
       public string ImageTitie {get; set;}
       public string ImageRoute {get; set;}
   }
    
   public enum StateofOutgoing { Waiting = 1, Picking = 2, Packing = 3, Outgoing = 4, Delivering = 5 }

   public class IncomingTag
   {
       [Key] public int IncomingTagNo { get; set; }
       public string CodeName { get; set; }

       public List<DividedTag> DividedTags {get; set;}
   }

   public class DividedTag
   {
       [Key] public int DividedTagNo {get; set;}
       public string CodeName {get; set;}

       public IncomingTag IncomingTag {get; set;}
   }

   public class LoadFrame
   {
       [Key] public int LoadFrameNo { get; set; }
       public string Code { get; set; }
       public List<DividedCommodity> DividedCommodities { get; set; }
   }

   public class ImageofWCommodity
   {
       [Key] public int ImageNo { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }

       public WCommodity WCommodity { get; set; }
   }

   public class ImageofIncoming
   {
       [Key] public int ImageNo { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }
       public DateTime DateTime { get; set; }

       public WCommodity WCommodity { get; set; }
   }

   public class ImageofLoading
   {
       [Key] public int ImageNo { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }
       public DateTime DateTime { get; set; }
    
       public DividedCommodity DividedCommodity {get; set;}
   }

   public class ImageofOutgoing
   {
       [Key] public int ImageNo { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }
       public DateTime DateTime { get; set; }
    
       public OutgoingCommodity OutgoingCommodity {get; set;}
   }

   public class ImageofDelivering
   {
       [Key] public int ImageNo { get; set; }
       public string Route { get; set; }
       public string Name { get; set; }
       public DateTime DateTime { get; set; }
    
       public OutgoingCommodity OutgoingCommodity {get; set;}
   }
}
