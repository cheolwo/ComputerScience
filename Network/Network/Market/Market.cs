using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Model
{
   public class Market
   {
       [Key] public int MarketNo { get; set; }
       public string User { get; set; }
       public List<MCommodity> MCommodities {get; set;}
        
       public Coupang Coupang { get; set; }
       public Ebay Ebay { get; set; }
       public CompanyMall Mall { get; set; }
   }
    
   public class MCommodity
   {
       [Key] public int MCommodityNo { get; set; }
       public int CommodityNo { get; set; }
       public int Quantity { get; set; }

       public List<MOrder> MOrders { get; set; }
       public Market Market {get; set;}
   }

   public class Coupang
   {
       [Key] public int CoupangNo { get; set; }
       public string VendorId { get; set; }
       public string AccessCode { get; set; }
       public string UserId { get; set; }
        
       public List<CCommodity> CCmodities {get; set;}
       public Market Market {get; set;}
   }

   public class Ebay
   {
       [Key] public int EbayNo { get; set; }
       public string VendorId { get; set; }
       public string AccessCode { get; set; }
       public string UserId { get; set; }

       public Market Market{get; set;}
   }

   public class CompanyMall
   {
       [Key] public int EbayNo { get; set; }
       public string VendorId { get; set; }
       public string AccessCode { get; set; }
       public string UserId { get; set; }

       public Market Market{get; set;}
   }
  
   public class MOrder
   {
       [Key] public int OrderNo { get; set; }
       public int Quantity {get; set;}
       public MOrderer MOrderer { get; set; }
       public MarketPlace MarketPlace {get; set;}
        
       public MCommodity MCommodity {get; set;}
       public MWarehouse MWarehouse {get; set;}
   }
    
   public class MOrderer
   {
       [Key] public int OrdererNo { get; set; }
       public string Name { get; set; }
       public string Email { get; set; }
       public string safeNumber { get; set; }
       public string OrdererNumber { get; set; }

       public List<MOrder> MOrders { get; set; }
   }

   public class MWarehouse
   {
       [Key] public int MWarehouseNo { get; set; }
       public int WarehouseNo { get; set; }
        
       public List<MCommodity> Mcommodities {get; set;}
       public List<MOrder> MOrders {get; set;}
   }
}
