using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trade.Model
{
    public class ImageofOption
    {
        [Key] public int ImageNo { get; set; }
        public string ImageTitle { get; set; }
        public string ImageRoute { get; set; }
      
        public List<ImageofDetail> ImagesofDetail {get; set;}
        public Option Option { get; set; }
    }
}
