using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Trade.Model
{
    public class ImageofCommodity
    {
        [Key] public int Id { get; set; }
        public string ImageRoute { get; set; }
        public string ImageTitle { get; set; }

        public Commodity Commodity { get; set; }
    }
}
