﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Model.ofSCommodity
{
    public class SCommodity
    {
        [Key] public int Id { get; set; }
        public string UserName {get; set;}
        [Required] public string Name { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }
      
        // public List<Buying> Buyings { get; set; }
        public List<Option> Options { get; set; }
        public DetailofSCommodity DetailofSCommodity { get; set; }
    }

    // public class CompanyofBuying
    // {
    //     [Key] public int SellerNo { get; set; } 
    //     public string Name { get; set; }
    //     public string Url { get; set; }
    //     public string PhoneNumber { get; set; }

    //     public List<Buying> Buyings { get; set; }
    // }

    // public class Buying
    // {
    //     [Key] public int SellNo { get; set; }
    //     public int Quantity { get; set; }
    //     public double Money { get; set; }

    //     public CompanyofBuying CompanyofBuying { get; set; }
    //     public SCommodity Commodity { get; set; }
    // }
}
