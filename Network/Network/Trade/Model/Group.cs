using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trade.Model
{
    public class Group
    {
        [Key] public int Id { get; set; }

        public string NameofBuyer { get; set; }
        public string NameofSeller { get; set; }
        public string NameofCustoms { get; set; }
        public string NameofDeliverofBuyer { get; set; }
        public string NameofDeliverofSeller { get; set; }

        public List<TCommodity> TCommodity { get; set; }
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
