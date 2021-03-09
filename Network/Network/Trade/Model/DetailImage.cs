using System.ComponentModel.DataAnnotations;

namespace Trade.Model
{
    public class DetailImage
    {
        [Key] public int DetailImageNo { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }

        public CommodityDetail CommodityDetail { get; set; }
    }
}