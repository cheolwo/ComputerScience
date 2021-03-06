﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.Model
{
    public class WCommodity
   {
       [Key] public int Id { get; set; }
       public string Name { get; set; }     // 상품 관리명
       public string Barcode {get; set;}    
       public double? Width {get; set;}
       public double? height {get; set;}
       public double? length { get; set; }
       
       public int TCommodityId {get; set;}
       public string Purpose {get; set;} // LOGISTICS_AGENCY, CROSS_DOCKING
       public StateofIncoming StateofIncoming { get; set; }
       public DateTime? IncomingTime { get; set; }
       public DateTime? InspectingTime { get; set; }
       public DateTime? LoadingTime { get; set; }

       // 책임 사람
       public string IncomingUser {get; set;}
       public string InspectingUser {get; set;}
       public int IncomingQuantity { get; set; }
       public int OutgoingQuantity {get; set;}
       public string IncomingTag { get; set; }

       public List<ImageofWCommodity> ImagesofWCommodity { get; set; }
       public List<ImageofIncoming> ImagesofIncoming { get; set; }
           
       public Base Base { get; set; }
       public List<DividedCommodity> DividedCommodities { get; set; }
       public List<OutgoingCommodity> OutgoingCommodities {get; set;}
   }
}
