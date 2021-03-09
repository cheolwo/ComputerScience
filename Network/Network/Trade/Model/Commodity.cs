using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trade.Model
{

    public class Commodity
    {
        [Key] public int Id { get; set; }
        public string NameofCommodity { get; set; }
        public string TCommodityId { get; set; }

        // public List<Buying> Buyings { get; set; }
        public List<ImageofCommodity> ImageofCommodities { get; set; }
        public List<Option> Options { get; set; }
        public CommodityDetail CommodityDetail { get; set; }
        public Group Group { get; set; }
    }

    //public class CompanyofBuying
    //{
    //    [Key] public int SellerNo { get; set; } 
    //    public string Name { get; set; }
    //    public string Url { get; set; }
    //    public string PhoneNumber { get; set; }

    //    public List<Buying> Buyings { get; set; }
    //}

    //public class Buying
    //{
    //    [Key] public int SellNo { get; set; }
    //    public int Quantity { get; set; }
    //    public double Money { get; set; }

    //    public CompanyofBuying CompanyofBuying { get; set; }
    //    public Commodity Commodity { get; set; }
    //}
}
