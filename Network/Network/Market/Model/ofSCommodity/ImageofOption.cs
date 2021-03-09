using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Market.Model
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
