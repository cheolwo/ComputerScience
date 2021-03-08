using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class Base
   {
       [Key] public int Id { get; set; }
       public string UserId {get; set;}  // 배송 및 물류대행업체
       public string Address { get; set; }
       public string Code {get; set;}
       public Country Country { get; set; }

       public List<ImageofBase> ImagesofBase {get; set;}
       public List<WCommodity> WCommodities { get; set; }
       public List<LoadFrame> LoadFrmaes { get; set; }
   }

   public enum Country { Korea = 1, China = 2, Japan = 3, Russia = 4, America = 5 }

   public enum StateofIncoming { Anticipating = 1, Inspecting = 2, Returing = 3, Loading = 4 }
    
   public enum StateofOutgoing { Waiting = 1, Picking = 2, Packing = 3, Outgoing = 4, Delivering = 5 }
}
