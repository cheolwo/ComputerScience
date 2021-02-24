using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Import.Model
{
    public class Option
    {
        [Key] public int OptionNo { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public Commodity Commodity { get; set; }

        public string NormalPrice { get; set; }
        public string SalePrice { get; set; }
        public int Quantity { get; set; }
        public string SellerCodeofCommodity { get; set; }
        public string ModelNo { get; set; }
        public string CommotityBarcode { get; set; }

        /// <summary>
        /// 대표이미지
        /// </summary>

        public List<Image> Images { get; set; }            
    }
}
