using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Import.Model
{
    public class Option
    {
        [Key] public int OptionNo { get; set; }
        [Required] public string Key { get; set; }
        [Required] public string Value { get; set; }
        [Required] public Commodity Commodity { get; set; }
        [Required] public string NormalPrice { get; set; }
        [Required] public string SalePrice { get; set; }
        [Required] public int Quantity { get; set; }
        public string SellerCodeofCommodity { get; set; }
        public string ModelNo { get; set; }
        public string CommotityBarcode { get; set; }

        public List<ImageofOption> Images { get; set; }
    }
}
