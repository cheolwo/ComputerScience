using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Import.Model
{
    public class Commodity
    {
        [Key] public int CommodityNo { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Url { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }
      
        public List<Option> Options { get; set; }
        public CommodityDetail CommodityDetail { get; set; }
    }
}
