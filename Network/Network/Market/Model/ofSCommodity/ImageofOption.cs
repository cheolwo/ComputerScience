using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Market.Model.ofSCommodity
{
    public class ImageofOption
    {
        [Key] public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }
      
        public List<ImageofDetail> ImagesofDetail {get; set;}
        public Option Option { get; set; }
    }
}
