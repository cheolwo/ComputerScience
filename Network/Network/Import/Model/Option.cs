using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Import.Model
{
    public class Option
    {
        [Key] public int OptionNo { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public Commodity Commodity { get; set; }
        //public string NormalPrice { get; set; }
        //public string SalePrice { get; set; }
        //public string SellerCodeofCommodity { get; set; }
        //public string ModelNo { get; set; }
        //public string CommotityBarcode { get; set; }

        public List<ImageofOption> Images { get; set; }
    }
}
